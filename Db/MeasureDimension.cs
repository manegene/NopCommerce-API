#nullable disable


namespace Nop.RestApi.Service.Db
{
    public partial class MeasureDimension
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SystemKeyword { get; set; }
        public decimal Ratio { get; set; }
        public int DisplayOrder { get; set; }
    }
}
