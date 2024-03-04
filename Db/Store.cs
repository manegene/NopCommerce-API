using System.Collections.Generic;

#nullable disable

namespace Nop.RestApi.Service.Db
{
    public partial class Store
    {
        public Store()
        {
            BlogComments = new HashSet<BlogComment>();
            NewsComments = new HashSet<NewsComment>();
            ProductReviews = new HashSet<ProductReview>();
            StoreMappings = new HashSet<StoreMapping>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Hosts { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public string CompanyPhoneNumber { get; set; }
        public string CompanyVat { get; set; }
        public bool SslEnabled { get; set; }
        public int DefaultLanguageId { get; set; }
        public int DisplayOrder { get; set; }

        public virtual ICollection<BlogComment> BlogComments { get; set; }
        public virtual ICollection<NewsComment> NewsComments { get; set; }
        public virtual ICollection<ProductReview> ProductReviews { get; set; }
        public virtual ICollection<StoreMapping> StoreMappings { get; set; }
    }
}
