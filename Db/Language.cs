using System.Collections.Generic;

#nullable disable

namespace Nop.RestApi.Service.Db
{
    public partial class Language
    {
        public Language()
        {
            BlogPosts = new HashSet<BlogPost>();
            LocaleStringResources = new HashSet<LocaleStringResource>();
            LocalizedProperties = new HashSet<LocalizedProperty>();
            News = new HashSet<News>();
            Polls = new HashSet<Poll>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string LanguageCulture { get; set; }
        public string UniqueSeoCode { get; set; }
        public string FlagImageFileName { get; set; }
        public bool Rtl { get; set; }
        public bool LimitedToStores { get; set; }
        public int DefaultCurrencyId { get; set; }
        public bool Published { get; set; }
        public int DisplayOrder { get; set; }

        public virtual ICollection<BlogPost> BlogPosts { get; set; }
        public virtual ICollection<LocaleStringResource> LocaleStringResources { get; set; }
        public virtual ICollection<LocalizedProperty> LocalizedProperties { get; set; }
        public virtual ICollection<News> News { get; set; }
        public virtual ICollection<Poll> Polls { get; set; }
    }
}
