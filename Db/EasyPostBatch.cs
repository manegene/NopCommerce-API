using System;

#nullable disable

namespace Nop.RestApi.Service.Db
{
    public partial class EasyPostBatch
    {
        public int Id { get; set; }
        public string BatchId { get; set; }
        public Guid BatchGuid { get; set; }
        public int StatusId { get; set; }
        public string LabelFormat { get; set; }
        public string ManifestUrl { get; set; }
        public string ShipmentIds { get; set; }
        public string PickupId { get; set; }
        public DateTime UpdatedOnUtc { get; set; }
        public DateTime CreatedOnUtc { get; set; }
    }
}
