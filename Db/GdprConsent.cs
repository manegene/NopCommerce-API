#nullable disable


namespace Nop.RestApi.Service.Db
{
    public partial class GdprConsent
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public bool IsRequired { get; set; }
        public string RequiredMessage { get; set; }
        public bool DisplayDuringRegistration { get; set; }
        public bool DisplayOnCustomerInfoPage { get; set; }
        public int DisplayOrder { get; set; }
    }
}
