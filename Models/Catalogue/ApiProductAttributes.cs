namespace Nop.RestApi.Service.Models.Catalogue
{
    public class ApiProductAttributes
    {
        public int Id { get; set; }
        public int AttId { get; set; }
        public string Baseattribute { get; set; }
        public string AttributesValue { get; set; }

        public int Mappingid { get; set; }
    }
}
