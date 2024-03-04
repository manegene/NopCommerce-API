using System;
using System.Text.Json.Serialization;

namespace Nop.RestApi.Service.Models.CheckOut
{
    public class ApiAddress
    {
        public int Id { get; set; }
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets the first name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name
        /// </summary>
        public string LastName { get; set; }

        //shipping address full name
        public string Name => FirstName + " " + LastName;

        /// <summary>
        /// Gets or sets the email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the country identifier
        /// </summary>
        public string Country { get; set; }

        public string Province { get; set; }

        public int StateProviceId { get; set; }

        public int CountryId { get; set; }
        /// <summary>
        /// Gets or sets the county
        /// </summary>
        [JsonPropertyName("State")]
        public string County { get; set; }

        /// <summary>
        /// Gets or sets the city
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Gets or sets the address 1
        /// </summary>
        public string Address1 { get; set; }

        /// <summary>
        /// Gets or sets the address 2
        /// </summary>
        public string Address2 { get; set; }

        /// <summary>
        /// Gets or sets the zip/postal code
        /// </summary>
        [JsonPropertyName("PostalCode")]
        public string ZipPostalCode { get; set; }

        /// <summary>
        /// Gets or sets the phone number
        /// </summary>
        [JsonPropertyName("MobileNo")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the date and time of instance creation
        /// </summary> 
        [JsonPropertyName("CreatedDate")]
        public DateTime CreatedOnUtc { get; set; }
    }
}
