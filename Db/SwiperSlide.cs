#nullable disable


namespace Nop.RestApi.Service.Db
{
    public partial class SwiperSlide
    {
        public int Id { get; set; }
        public string Body { get; set; }
        public string Caption { get; set; }
        public string Header { get; set; }
        public string PictureTitle { get; set; }
        public bool ApplyForHomepage { get; set; }
        public string BodyAnimation { get; set; }
        public string BodyAnimationDelay { get; set; }
        public string Footer { get; set; }
        public string FooterAnimation { get; set; }
        public string FooterAnimationDelay { get; set; }
        public string HeaderAnimation { get; set; }
        public string HeaderAnimationDelay { get; set; }
        public bool LimitedToStores { get; set; }
        public string PictureAlt { get; set; }
        public int PictureHeight { get; set; }
        public int PictureWidth { get; set; }
        public bool Publish { get; set; }
        public int SlideOrder { get; set; }
        public int PictureId { get; set; }
        public int? ManufactureId { get; set; }
        public int? CategoryId { get; set; }
    }
}
