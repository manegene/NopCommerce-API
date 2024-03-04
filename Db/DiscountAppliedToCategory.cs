#nullable disable


namespace Nop.RestApi.Service.Db
{
    public partial class DiscountAppliedToCategory
    {
        public int DiscountId { get; set; }
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
        public virtual Discount Discount { get; set; }
    }
}
