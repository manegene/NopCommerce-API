using System;
using System.Collections.Generic;

#nullable disable

namespace Nop.RestApi.Service.Db
{
    public partial class Address
    {
        public Address()
        {
            Affiliates = new HashSet<Affiliate>();
            CustomerAddresses = new HashSet<CustomerAddress>();
            CustomerBillingAddresses = new HashSet<Customer>();
            CustomerShippingAddresses = new HashSet<Customer>();
            OrderBillingAddresses = new HashSet<Order>();
            OrderPickupAddresses = new HashSet<Order>();
            OrderShippingAddresses = new HashSet<Order>();
        }

        public int Id { get; set; }
        public int? CountryId { get; set; }
        public int? StateProvinceId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Company { get; set; }
        public string County { get; set; }
        public string City { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string ZipPostalCode { get; set; }
        public string PhoneNumber { get; set; }
        public string FaxNumber { get; set; }
        public string CustomAttributes { get; set; }
        public DateTime CreatedOnUtc { get; set; }

        public virtual Country Country { get; set; }
        public virtual StateProvince StateProvince { get; set; }
        public virtual ICollection<Affiliate> Affiliates { get; set; }
        public virtual ICollection<CustomerAddress> CustomerAddresses { get; set; }
        public virtual ICollection<Customer> CustomerBillingAddresses { get; set; }
        public virtual ICollection<Customer> CustomerShippingAddresses { get; set; }
        public virtual ICollection<Order> OrderBillingAddresses { get; set; }
        public virtual ICollection<Order> OrderPickupAddresses { get; set; }
        public virtual ICollection<Order> OrderShippingAddresses { get; set; }
    }
}
