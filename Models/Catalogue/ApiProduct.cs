using Nop.RestApi.Service.Db;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Nop.RestApi.Service.Models.Catalogue
{
    public class ApiProduct
    {
        public virtual string GetFileExtensionFromMimeType(string mimeType)
        {
            if (mimeType == null)
            {
                return null;
            }

            string[] parts = mimeType.Split('/');
            string lastPart = parts[^1];
            switch (lastPart)
            {
                case "pjpeg":
                    lastPart = "jpg";
                    break;
                case "x-png":
                    lastPart = "png";
                    break;
                case "x-icon":
                    lastPart = "ico";
                    break;
            }

            return lastPart;
        }





        [JsonIgnore]
        public string Imagetype { get; set; }

        [JsonIgnore]
        public string Imagename { get; set; }
        [JsonIgnore]
        public int Prodpicid { get; set; }
        public int Id { get; set; }
        public string Pname { get; set; }

        //seo name for mobile app sharing
        public string SeoPname { get; set; }
        public string Uri { get; set; }

        [JsonIgnore]
        public string OrderProdAttributeXML { get; set; }
        public string ShortDescription { get; set; }
        public string FullDescription { get; set; }

        [JsonIgnore]
        public string Imagetypes => GetFileExtensionFromMimeType(Imagetype);
        public string Previewmage => $"{Prodpicid:0000000}_{Imagename}.{Imagetypes}";
        public decimal Price { get; set; }
        public decimal Oldprice { get; set; }
        public int ApprovedRatingSum { get; set; }
        public int TotalQuantity { get; set; }
        public int CustomerId { get; set; }
        public int Quantity { get; set; }

        public int ProductId { get; set; }
        public bool IsNewProduct { get; set; }
        public string Currency { get; set; }
        public bool HasAttributes { get; set; }
        public IList<Picture> Images { get; set; }
        public IList<ProductReview> Reviews { get; set; }
        public ApiCategory ProdCategory { get; set; }

        //product attributes section
        public IList<ApiProductAttributes> Attributes { get; set; }

    }
}
