namespace Nop.RestApi.Service.Models.Catalogue
{
    public class ApiReview
    {
        public int ProdId { get; set; }
        public string Title { get; set; }
        public int UserId { get; set; }
        public string ReviewText { get; set; }
        public int Rating { get; set; }

    }
}
