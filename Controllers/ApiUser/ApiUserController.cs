using Microsoft.AspNetCore.Mvc;
using Nop.RestApi.Service.Controllers.Core;
using Nop.RestApi.Service.Db;
using Nop.RestApi.Service.Models.ApiUser;
using Nop.RestApi.Service.Models.core;
using Nop.RestApi.Service.Services.Core;
using Nop.RestApi.Service.Services.CustomerServices;
using System;
using System.Collections.Generic;

namespace Nop.RestApi.Service.Controllers.ApiUser
{
    public class ApiUserController : BaseAuthController
    {
        #region fields
        private readonly ICustomerService _apiUserService;
        private readonly IApiMessageService _apimessageservice;
        #endregion fields

        #region ctor
        public ApiUserController(ICustomerService apiCustomerService, IApiMessageService apiMessageService)
        {
            _apiUserService = apiCustomerService;
            _apimessageservice = apiMessageService;
        }
        #endregion ctor

        #region endpoints
        //user login endpoint
        [HttpPost]
        [Route("Login")]
        public ActionResult<ApiCustomer> GetActionResult(ApiCustomer customerLogin)
        {
            if (customerLogin.Email == null)
            {
                return NotFound("missing email");
            }

            if (customerLogin.Password == null)
            {
                return NotFound("missing password");
            }

            string email = customerLogin.Email.Trim();
            ApiCustomer customer = _apiUserService.GetByEmail(email);

            if (customer != null)
            {
                Db.CustomerPassword existpassword = _apiUserService.GetCustomerSavedPass(customer.Userid);

                bool samepass = _apiUserService.PasswordsMatch(existpassword, customerLogin.Password);
                if (samepass)
                {
                    {
                        ApiCustomer loggedinuser = customer;//_customerService.Login(email, customerLogin.Password);
                        return Ok(loggedinuser);

                    }

                }
                return BadRequest("password does not exist.please register or reset your password");
            }
            return NotFound("email not associated with an ative user");


        }

        //register new user endpoint
        [HttpPost]
        [Route("signup")]
        public ActionResult<ApiCustomer> Signup(ApiCustomer customer)
        {
            if (customer != null)
            {
                try
                {
                    if (!string.IsNullOrEmpty(customer.Email.Trim()))
                    {
                        //check if user email exists already
                        ApiCustomer exists = _apiUserService.GetByEmail(customer.Email);
                        if (exists != null)
                        {
                            return BadRequest(customer.Email + " already exists");
                        }

                        string useremail = customer.Email.Trim();
                        DateTime regtime = DateTime.UtcNow;
                        //get the salt key to be use to hash the pasword
                        string saltvalue = _apiUserService.GenerateSalt();
                        string hashedpassword = _apiUserService.CreatePasswordHash(customer.Password, saltvalue, "SHA512");

                        Customer regdetails = new()
                        {
                            Email = useremail,
                            Username = useremail,
                            CustomerGuid = Guid.NewGuid(),
                            Active = true,
                            IsSystemAccount = false,
                            CreatedOnUtc = regtime,
                            LastActivityDateUtc = regtime,
                            RegisteredInStoreId = _apimessageservice.GetStore().Id

                        };



                        bool stats = _apiUserService.InsertCustomer(regdetails);

                        if (stats == false)
                        {
                            return BadRequest("error registering user details. please try again");
                        }

                        //get userid to use in password and attributes table
                        int user = _apiUserService.GetByEmail(useremail).Userid;

                        //user password details
                        CustomerPassword regpassword = new()
                        {
                            CustomerId = user,
                            Password = hashedpassword,
                            PasswordFormatId = 1,
                            CreatedOnUtc = regtime,
                            PasswordSalt = saltvalue
                        };

                        //now insert password 
                        _apiUserService.InsertPassword(regpassword);

                        //firstname attribute
                        GenericAttribute fname = new()
                        {
                            EntityId = user,
                            Key = "FirstName",
                            KeyGroup = "Customer",
                            Value = customer.Firstname,
                            CreatedOrUpdatedDateUtc = regtime
                        };
                        //lastname
                        GenericAttribute lname = new()
                        {
                            EntityId = user,
                            Key = "LastName",
                            KeyGroup = "Customer",
                            Value = customer.LastName,
                            CreatedOrUpdatedDateUtc = regtime
                        };
                        //phonenumber
                        GenericAttribute phone = new()
                        {
                            EntityId = user,
                            Key = "Phone",
                            KeyGroup = "Customer",
                            Value = customer.Phone,
                            CreatedOrUpdatedDateUtc = regtime
                        };
                        List<GenericAttribute> attributeslist = new()
                        {
                            fname,
                            lname,
                            phone
                        };


                        //loop through all attributes and insert them 
                        foreach (GenericAttribute attribute in attributeslist)
                        {
                            _apiUserService.InsertAtts(attribute);

                        };

                        //update userrole mapping
                        CustomerCustomerRoleMapping updaterole = new()
                        {
                            CustomerId = user,
                            CustomerRoleId = 3 //registered user roleid


                        };
                        _apiUserService.UpdateCustomerRole(updaterole);

                        //get the message template resources
                        MessageTemplate template = _apimessageservice.GetActiveMessageTemplates("Customer.WelcomeMessage");

                        //get store values
                        Store stor = _apimessageservice.GetStore();
                        //get email
                        EmailAccount storeemail = _apimessageservice.GetStoreEmail();

                        string replacedsubject = _apimessageservice.ReplaceTemplate(template.Subject, customer, stor, storeemail);
                        string replacedbody = _apimessageservice.ReplaceTemplate(template.Body, customer, stor, storeemail);
                        QueuedEmail queuedEmail = new()
                        {
                            To = useremail,
                            ToName = customer.Firstname + " " + customer.LastName,
                            From = storeemail.Email,
                            FromName = storeemail.DisplayName,
                            Subject = replacedsubject,
                            Body = replacedbody,
                            EmailAccountId = storeemail.Id,
                            AttachedDownloadId = 0,
                            CreatedOnUtc = regtime,
                            PriorityId = 5


                        };


                        //now send  the customer welcome email
                        _apimessageservice.AddMsgQueue(queuedEmail);

                        //also notify store owner if notify setting is enables
                        Setting checknotifynewcustomer = _apimessageservice.ReadSettings(stor.Id, "customersettings.notifynewcustomerregistration");
                        if (checknotifynewcustomer.Value == "True")
                        {
                            //get notify template
                            MessageTemplate notifytemplae = _apimessageservice.GetActiveMessageTemplates("Customer.WelcomeMessage");

                            string notifysubject = _apimessageservice.ReplaceTemplate(template.Subject, customer, stor, storeemail);
                            string notifybody = _apimessageservice.ReplaceTemplate(template.Body, customer, stor, storeemail);

                            QueuedEmail notifystoreowner = new()
                            {
                                To = storeemail.Email,
                                ToName = stor.CompanyName,
                                FromName = stor.Name,
                                From = storeemail.Email,
                                Subject = notifysubject,
                                Body = notifybody,
                                EmailAccountId = storeemail.Id,
                                CreatedOnUtc = regtime,
                                PriorityId = 5

                            };
                            _apimessageservice.AddMsgQueue(notifystoreowner);

                        }

                        //success register aand email send
                        return Ok("user added successfully");
                        // return Ok(replacedsubject +" "+ replacedbody);
                    }

                }
                catch (Exception ex)
                {
                    return BadRequest(ex);
                }
            }
            return BadRequest("complete missing fields");
        }
        //emeil recovery
        [HttpPost]
        [Route("forgot")]
        public ActionResult ResetPassword(ApiPasswordRecovery apiPasswordRecovery)
        {
            //generae new password token
            string passwordrecoverytoken = Guid.NewGuid().ToString();
            DateTime currenttime = DateTime.UtcNow;
            Store currentstore = _apimessageservice.GetStore();
            EmailAccount storeemail = _apimessageservice.GetStoreEmail();

            //find if user already exist and is active
            string useremail = apiPasswordRecovery.Email.Trim();
            ApiCustomer customer = _apiUserService.GetByEmail(useremail);
            if (customer == null)
            {
                return BadRequest("user does not exist");
            }

            //user with given email exists.Its okay to try res
            //save new recovery token
            GenericAttribute tokengenerated = new()
            {
                KeyGroup = "Customer",
                Key = "PasswordRecoveryToken",
                Value = passwordrecoverytoken,
                EntityId = customer.Userid,
                StoreId = customer.RegisteredInStoreId,
                CreatedOrUpdatedDateUtc = currenttime

            };
            GenericAttribute tokengenratedate = new()
            {
                KeyGroup = "Customer",
                Key = "PasswordRecoveryTokenDateGenerated",
                Value = currenttime.ToString("MM/dd/yyyy HH:mm:ss"),
                EntityId = customer.Userid,
                StoreId = customer.RegisteredInStoreId,
                CreatedOrUpdatedDateUtc = currenttime
            };
            List<GenericAttribute> listoftokenattributes = new()
            {
                tokengenratedate,
                tokengenerated
            };

            //send to database
            foreach (GenericAttribute token in listoftokenattributes)
            {
                _apiUserService.InsertAtts(token);
            }

            //get message template
            MessageTemplate recoverytemplate = _apimessageservice.GetActiveMessageTemplates("Customer.PasswordRecovery");

            //replace message token
            string replacedsubject = _apimessageservice.ReplaceTemplate(recoverytemplate.Subject, customer, currentstore, storeemail);
            string replacedbody = _apimessageservice.ReplaceTemplate(recoverytemplate.Body, customer, currentstore, storeemail);

            if (replacedbody.Contains("%Customer.PasswordRecoveryURL%"))
            {

                replacedbody = replacedbody.Replace("%Customer.PasswordRecoveryURL%", currentstore.Url + "passwordrecovery/confirm?token=" + passwordrecoverytoken + "&guid=" + customer.CustomerGuid);
            }
            QueuedEmail recoveryemail = new()
            {
                To = useremail,
                ToName = customer.Firstname + " " + customer.LastName,
                From = storeemail.Email,
                FromName = storeemail.DisplayName,
                Subject = replacedsubject,
                Body = replacedbody,
                EmailAccountId = storeemail.Id,
                AttachedDownloadId = 0,
                CreatedOnUtc = currenttime,
                PriorityId = 5


            };
            //send message
            _apimessageservice.AddMsgQueue(recoveryemail);

            return Ok("revorey email link sent");
        }

        //Contact us from mobile api
        [HttpPost]
        [Route("Contactus")]
        public virtual IActionResult ContactUsSend(ApiContactUs apicontactus)
        {
            if (apicontactus == null)
            {
                return BadRequest();
            }

            if (string.IsNullOrEmpty(apicontactus.Email))
            {
                return BadRequest("email cannot be empty");
            }

            if (string.IsNullOrEmpty(apicontactus.Message))
            {
                return BadRequest("message cannot be empty");
            }

            if (string.IsNullOrEmpty(apicontactus.Name))
            {
                return BadRequest("your name cannot be empty");
            }

            EmailAccount storeemail = _apimessageservice.GetStoreEmail();
            Store thisstore = _apimessageservice.GetStore();
            DateTime contactdate = DateTime.UtcNow;
            QueuedEmail contactusmessgae = new()
            {
                To = storeemail.Email,
                ToName = thisstore.CompanyName,
                From = apicontactus.Email,
                FromName = apicontactus.Name,
                Body = apicontactus.Message,
                Subject = "Api contact",
                CreatedOnUtc = contactdate,
                EmailAccountId = storeemail.Id

            };

            //send email
            _apimessageservice.AddMsgQueue(contactusmessgae);

            return Ok("successfully sent your message");
        }

        #endregion endpoints
    }
}
