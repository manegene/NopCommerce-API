#nullable disable


namespace Nop.RestApi.Service.Db
{
    public partial class ProductCategoryMapping
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int ProductId { get; set; }
        public bool IsFeaturedProduct { get; set; }
        public int DisplayOrder { get; set; }

        public virtual Category Category { get; set; }
        public virtual Product Product { get; set; }
    }
}
