using System;
using System.Text.Json.Serialization;

namespace Nop.RestApi.Service.Models.ApiUser
{
    public partial class ApiCustomer
    {
        public ApiCustomer()
        {
            // CustomerGuid = Guid.NewGuid();
        }
        public bool HasShoppingCartItems { get; set; }

        [JsonIgnore]
        public Guid CustomerGuid { get; set; }

        [JsonPropertyName("Message")]
        public string Message { get; set; }

        [JsonPropertyName("Id")]
        public int Userid { get; set; }

        [JsonPropertyName("Name")]
        public string Username { get; set; }

        public string Password { get; set; }


        [JsonPropertyName("EmailId")]
        public string Email { get; set; }

        [JsonPropertyName("AddressId")]
        public int? AddressId { get; set; }

        [JsonPropertyName("Success")]
        public bool Statuscode { get; set; }

        [JsonPropertyName("Firstname")]
        public string Firstname { get; set; }

        public string LastName { get; set; }

        public string Phone { get; set; }
        public string AdminComment { get; set; }
        public bool IsTaxExempt { get; set; }
        public int AffiliateId { get; set; }
        public bool RequireReLogin { get; set; }
        public bool Active { get; set; }
        public bool Deleted { get; set; }
        public bool IsSystemAccount { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public int RegisteredInStoreId { get; set; }


    }
}
