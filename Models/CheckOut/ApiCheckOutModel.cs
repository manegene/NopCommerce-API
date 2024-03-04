namespace Nop.RestApi.Service.Models.CheckOut
{
    public class ApiCheckOutModel
    {
        public int AddressId { get; set; }
        public int UserId { get; set; }
        public string PaymentMode { get; set; }
    }
}
