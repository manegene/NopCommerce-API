#nullable disable


namespace Nop.RestApi.Service.Db
{
    public partial class LocalizedProperty
    {
        public int Id { get; set; }
        public string LocaleKeyGroup { get; set; }
        public string LocaleKey { get; set; }
        public string LocaleValue { get; set; }
        public int LanguageId { get; set; }
        public int EntityId { get; set; }

        public virtual Language Language { get; set; }
    }
}
