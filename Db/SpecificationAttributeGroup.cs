using System.Collections.Generic;

#nullable disable

namespace Nop.RestApi.Service.Db
{
    public partial class SpecificationAttributeGroup
    {
        public SpecificationAttributeGroup()
        {
            SpecificationAttributes = new HashSet<SpecificationAttribute>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int DisplayOrder { get; set; }

        public virtual ICollection<SpecificationAttribute> SpecificationAttributes { get; set; }
    }
}
