using System.Collections.Generic;

#nullable disable

namespace Nop.RestApi.Service.Db
{
    public partial class CustomerAttribute
    {
        public CustomerAttribute()
        {
            CustomerAttributeValues = new HashSet<CustomerAttributeValue>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsRequired { get; set; }
        public int AttributeControlTypeId { get; set; }
        public int DisplayOrder { get; set; }

        public virtual ICollection<CustomerAttributeValue> CustomerAttributeValues { get; set; }
    }
}
