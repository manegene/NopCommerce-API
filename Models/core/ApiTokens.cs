using System.Collections.Generic;

namespace Nop.RestApi.Service.Models.core
{
    public class ApiTokens
    {
        public static List<string> CustTokens = new()
        {
            "%Customer.Email%",
            "%Customer.Username%",
            "%Customer.FullName%",
            "%Customer.FirstName%",
            "%Customer.LastName%",
            "%Customer.PasswordRecoveryURL%",

        };
        public static List<string> StoreTokens = new()
        {
            "%Store.Name%",
            "%Store.URL%",
            "%Store.Email%",
            "%Store.CompanyName%",
            "%Facebook.URL%",
            "%Twitter.URL%",
            "%YouTube.URL%"

        };

        public static List<string> OrderTokens = new()
        {
            "%Order.OrderNumber%",
            "%Order.CustomerFullName%",
            "%Order.CustomerEmail%",
            "%Order.BillingFirstName%",
            "%Order.BillingLastName%",
            "%Order.BillingPhoneNumber%",
            "%Order.BillingEmail%",
            "%Order.BillingAddress1%",
            "%Order.BillingCity%",
            "%Order.BillingCounty%",
            "%Order.BillingStateProvince%",
            "%Order.BillingZipPostalCode%",
            "%Order.BillingCountry%",
            "%Order.ShippingFirstName%",
            "%Order.ShippingLastName%",
            "%Order.ShippingPhoneNumber%",
            "%Order.ShippingEmail%",
            "%Order.ShippingAddress1%",
            "%Order.ShippingCity%",
            "%Order.ShippingCounty%",
            "%Order.ShippingStateProvince%",
            "%Order.ShippingZipPostalCode%",
            "%Order.ShippingCountry%",
            "%Order.ShippingCustomAttributes%",
            "%Order.PaymentMethod%",
            "%Order.VatNumber%",
            "%Order.Product(s)%",
            "%Order.CreatedOn%",
            "%Order.OrderId%"
        };

    }
}
