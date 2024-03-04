﻿using System;

#nullable disable

namespace Nop.RestApi.Service.Db
{
    public partial class StockQuantityHistory
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int? WarehouseId { get; set; }
        public int QuantityAdjustment { get; set; }
        public int StockQuantity { get; set; }
        public string Message { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public int? CombinationId { get; set; }

        public virtual Product Product { get; set; }
    }
}
