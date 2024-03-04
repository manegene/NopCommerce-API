using System.Collections.Generic;

#nullable disable

namespace Nop.RestApi.Service.Db
{
    public partial class SpecificationAttribute
    {
        public SpecificationAttribute()
        {
            SpecificationAttributeOptions = new HashSet<SpecificationAttributeOption>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
        public int? SpecificationAttributeGroupId { get; set; }

        public virtual SpecificationAttributeGroup SpecificationAttributeGroup { get; set; }
        public virtual ICollection<SpecificationAttributeOption> SpecificationAttributeOptions { get; set; }
    }
}
