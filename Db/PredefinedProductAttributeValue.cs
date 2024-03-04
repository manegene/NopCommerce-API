﻿#nullable disable


namespace Nop.RestApi.Service.Db
{
    public partial class PredefinedProductAttributeValue
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ProductAttributeId { get; set; }
        public decimal PriceAdjustment { get; set; }
        public bool PriceAdjustmentUsePercentage { get; set; }
        public decimal WeightAdjustment { get; set; }
        public decimal Cost { get; set; }
        public bool IsPreSelected { get; set; }
        public int DisplayOrder { get; set; }

        public virtual ProductAttribute ProductAttribute { get; set; }
    }
}
