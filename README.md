# Opensource REST API
If this project help you reduce time to develop, you can buy me a cup of coffee :)  
[![paypal](https://www.paypalobjects.com/en_US/i/btn/btn_donateCC_LG.gif)](https://www.paypal.com/donate/?hosted_button_id=XMQSX7J83V5AN)
#
This project is built on Nopcommerce Opensource E-commerce database model
It is meant to work on any Nopcommerce store without the need to keep updating the dependencies/methods with each new Nopcommerce version releases.
The API is a standalone project and should be hosted on its own IIS instance pool--do not upload it to your store like regular plugin.

##Prerequisites
1. Firebase account

###Getting started
1. Setup a firebase account https://console.firebase.google.com/
2. Setup project service account
3. Generate a service account key in the FirebaseAdminSDK console(use the recommended json option) https://console.cloud.google.com/
4. The downloded json file, save it and place it at the Google folder in the project.(rename the json file to firebase_key.json)

#####Update project files
Open the appsettings.json. We need to update the SQL connection string and the JWT credentials
1. From your nopcommerce site, copy the connection string and update AppConnString section.
2. From the firebase json file downlaoded above, copy the project_id. Update the value in {project id}(remove curly braces after update)

Now build and run your api site. 

## List of supported Methods/endpoint:

### Products:
1. https://mydomain/api/products --Gets all published products
2. https://mydomain/api/products/{productid} --Gets the product with the specified ID
3. https://mydomain/api/products/getprodbycategoryid?{subCategoryId} -- Gets the products in the specified category id
4. https://mydomain/api/products/categories -- Gets list of the active categories
5. https://mydomain/api/products/addreview?{json body: prodid={int}&userid={int}&title={string}&reviewtext{string}&rating={int}} -- Posts the product review

### AttributesXml:
1. https://mydomain/api/attributesxml?{prodid={productid}&Ienumerable<attributeid>{int}}
### Wishlist/Shopping cart:
  
  1.https://mydomain/api/cart/addtocart?{Json body: userid=int&productid={int}&carttype={int}&attributesXML{?string}&isfavorite=bool} --post/update/delete wishlist or shopping ### cart item.
  
 2.https://mydomain/api/cart/getcartitem?{Json body: userid={int}&carttype={int}} --get wishlist/shopping cart products. Variation is the carttype id

### User/Customer account:
  1. https://domain/api/apiuser/login{json body:emailid,password}  --login user 
  2. https://mydomain/api/apiuser/signup {json body:emailid,password,firstname,lastname,phone} --post a new user
  3. https://mydomain/api/apiuser/forgot {json body:email} --user get a reset password token and email
  4. https://mydoamain/api/apiuser/contactus {json body: name,email,message} --user contact store
  
### Order/Checkout:
  1. https://mydomain/api/checkout/Paymentmethods --returns payment methods(hard coded and does not read from store setting:CoD,flutterwave and paypal))
  2. https://mydomain/api/checkout/Getshippingaddress?{Json body: int userid} --returns a user shipping/billing address
  3. https://mydomain/api/checkout/Listcountries --returns store published and eligible countries
  4: https://mydomain/api/checkout/myorders?{Json body: int id} --returns a user order history
  4. https://mydomain/api/checkout/addaddress{ Json body: int userid, int countryid, string county, string city,
            string phone, string pcode, string firstname, string lastname, string address, string email} --Post a new user address
  6. https://mydomain/api/checkout/placeorder?{Json body: int addressid, string paymentmode, int userid} --A new order is posted
  
 ### Store details:
 *. https://mydomain/api/StoreAbout --Get method to return store details
