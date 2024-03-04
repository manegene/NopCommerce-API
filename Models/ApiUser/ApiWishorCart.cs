namespace Nop.RestApi.Service.Models.ApiUser
{
    public class ApiWishorCart
    {
        public int CartType { get; set; }
        public int Userid { get; set; }
        public int ProductId { get; set; }
        public string AttributesXML { get; set; }
        public bool IsFavorite { get; set; }
    }
}
