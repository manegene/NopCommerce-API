using System.Collections.Generic;

#nullable disable

namespace Nop.RestApi.Service.Db
{
    public partial class ProductAttribute
    {
        public ProductAttribute()
        {
            PredefinedProductAttributeValues = new HashSet<PredefinedProductAttributeValue>();
            ProductProductAttributeMappings = new HashSet<ProductProductAttributeMapping>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<PredefinedProductAttributeValue> PredefinedProductAttributeValues { get; set; }
        public virtual ICollection<ProductProductAttributeMapping> ProductProductAttributeMappings { get; set; }
    }
}
