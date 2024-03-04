using System.Collections.Generic;

#nullable disable

namespace Nop.RestApi.Service.Db
{
    public partial class ShippingMethod
    {
        public ShippingMethod()
        {
            ShippingMethodRestrictions = new HashSet<ShippingMethodRestriction>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int DisplayOrder { get; set; }

        public virtual ICollection<ShippingMethodRestriction> ShippingMethodRestrictions { get; set; }
    }
}
