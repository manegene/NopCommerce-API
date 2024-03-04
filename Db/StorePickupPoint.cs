﻿#nullable disable


namespace Nop.RestApi.Service.Db
{
    public partial class StorePickupPoint
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int AddressId { get; set; }
        public decimal PickupFee { get; set; }
        public string OpeningHours { get; set; }
        public int DisplayOrder { get; set; }
        public int StoreId { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
        public int? TransitDays { get; set; }
    }
}
