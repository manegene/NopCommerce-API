#nullable disable


namespace Nop.RestApi.Service.Db
{
    public partial class DiscountAppliedToManufacturer
    {
        public int DiscountId { get; set; }
        public int ManufacturerId { get; set; }

        public virtual Discount Discount { get; set; }
        public virtual Manufacturer Manufacturer { get; set; }
    }
}
