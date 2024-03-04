#nullable disable


namespace Nop.RestApi.Service.Db
{
    public partial class PictureBinary
    {
        public int Id { get; set; }
        public int PictureId { get; set; }
        public byte[] BinaryData { get; set; }

        public virtual Picture Picture { get; set; }
    }
}
