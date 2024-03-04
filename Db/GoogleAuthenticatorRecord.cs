#nullable disable


namespace Nop.RestApi.Service.Db
{
    public partial class GoogleAuthenticatorRecord
    {
        public int Id { get; set; }
        public string Customer { get; set; }
        public string SecretKey { get; set; }
    }
}
