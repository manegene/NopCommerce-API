using System.Collections.Generic;

#nullable disable

namespace Nop.RestApi.Service.Db
{
    public partial class ReviewType
    {
        public ReviewType()
        {
            ProductReviewReviewTypeMappings = new HashSet<ProductReviewReviewTypeMapping>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int DisplayOrder { get; set; }
        public bool VisibleToAllCustomers { get; set; }
        public bool IsRequired { get; set; }

        public virtual ICollection<ProductReviewReviewTypeMapping> ProductReviewReviewTypeMappings { get; set; }
    }
}
