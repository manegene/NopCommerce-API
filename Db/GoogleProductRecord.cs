#nullable disable


namespace Nop.RestApi.Service.Db
{
    public partial class GoogleProductRecord
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string Taxonomy { get; set; }
        public bool CustomGoods { get; set; }
        public string Gender { get; set; }
        public string AgeGroup { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public string Material { get; set; }
        public string Pattern { get; set; }
    }
}
