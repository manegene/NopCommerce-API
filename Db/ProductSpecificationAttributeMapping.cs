﻿#nullable disable


namespace Nop.RestApi.Service.Db
{
    public partial class ProductSpecificationAttributeMapping
    {
        public int Id { get; set; }
        public string CustomValue { get; set; }
        public int ProductId { get; set; }
        public int SpecificationAttributeOptionId { get; set; }
        public int AttributeTypeId { get; set; }
        public bool AllowFiltering { get; set; }
        public bool ShowOnProductPage { get; set; }
        public int DisplayOrder { get; set; }

        public virtual Product Product { get; set; }
        public virtual SpecificationAttributeOption SpecificationAttributeOption { get; set; }
    }
}
