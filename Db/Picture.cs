using System.Collections.Generic;

#nullable disable

namespace Nop.RestApi.Service.Db
{
    public partial class Picture
    {
        public Picture()
        {
            PictureBinaries = new HashSet<PictureBinary>();
            ProductPictureMappings = new HashSet<ProductPictureMapping>();
        }

        public int Id { get; set; }
        public string MimeType { get; set; }
        public string SeoFilename { get; set; }
        public string AltAttribute { get; set; }
        public string TitleAttribute { get; set; }
        public bool IsNew { get; set; }
        public string VirtualPath { get; set; }

        public virtual ICollection<PictureBinary> PictureBinaries { get; set; }
        public virtual ICollection<ProductPictureMapping> ProductPictureMappings { get; set; }
    }
}
