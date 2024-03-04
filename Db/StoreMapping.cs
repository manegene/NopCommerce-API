#nullable disable


namespace Nop.RestApi.Service.Db
{
    public partial class StoreMapping
    {
        public int Id { get; set; }
        public string EntityName { get; set; }
        public int StoreId { get; set; }
        public int EntityId { get; set; }

        public virtual Store Store { get; set; }
    }
}
