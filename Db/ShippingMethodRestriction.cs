#nullable disable


namespace Nop.RestApi.Service.Db
{
    public partial class ShippingMethodRestriction
    {
        public int ShippingMethodId { get; set; }
        public int CountryId { get; set; }

        public virtual Country Country { get; set; }
        public virtual ShippingMethod ShippingMethod { get; set; }
    }
}
