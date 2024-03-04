using Nop.RestApi.Service.Db;
using Nop.RestApi.Service.Models.Catalogue;
using Nop.RestApi.Service.Models.core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace Nop.RestApi.Service.Services.Catalogue
{
    public class ProductService : IProductService
    {
        #region fields

        private readonly ApiContext _context;


        #endregion fields
        #region ctor
        public ProductService(
             ApiContext apiContext
             )
        {
            _context = apiContext;
        }
        #endregion ctor
        #region methods
        #region complimentary methods

        /// <summary>
        /// Adds an attribute
        /// </summary>
        /// <param name="attributesXml">Attributes in XML format</param>
        /// <param name="productAttributeMapping">Product attribute mapping</param>
        /// <param name="value">Value</param>
        /// <param name="quantity">Quantity (used with AttributeValueType.AssociatedToProduct to specify the quantity entered by the customer)</param>
        /// <returns>Updated result (XML format)</returns>
        public virtual string AddProductAttribute(string attributesXml, ProductProductAttributeMapping productAttributeMapping, string value, int? quantity = null)
        {
            string result = string.Empty;
            try
            {
                XmlDocument xmlDoc = new();
                if (string.IsNullOrEmpty(attributesXml))
                {
                    XmlElement element1 = xmlDoc.CreateElement("Attributes");
                    _ = xmlDoc.AppendChild(element1);
                }
                else
                {
                    xmlDoc.LoadXml(attributesXml);
                }

                XmlElement rootElement = (XmlElement)xmlDoc.SelectSingleNode(@"//Attributes");

                XmlElement attributeElement = null;
                //find existing
                XmlNodeList nodeList1 = xmlDoc.SelectNodes(@"//Attributes/ProductAttribute");
                foreach (XmlNode node1 in nodeList1)
                {
                    if (node1.Attributes?["ID"] == null)
                    {
                        continue;
                    }

                    string str1 = node1.Attributes["ID"].InnerText.Trim();
                    if (!int.TryParse(str1, out int id))
                    {
                        continue;
                    }

                    if (id != productAttributeMapping.Id)
                    {
                        continue;
                    }

                    attributeElement = (XmlElement)node1;
                    break;
                }

                //create new one if not found
                if (attributeElement == null)
                {
                    attributeElement = xmlDoc.CreateElement("ProductAttribute");
                    attributeElement.SetAttribute("ID", productAttributeMapping.Id.ToString());
                    _ = rootElement.AppendChild(attributeElement);
                }

                XmlElement attributeValueElement = xmlDoc.CreateElement("ProductAttributeValue");
                _ = attributeElement.AppendChild(attributeValueElement);

                XmlElement attributeValueValueElement = xmlDoc.CreateElement("Value");
                attributeValueValueElement.InnerText = value;
                _ = attributeValueElement.AppendChild(attributeValueValueElement);

                //the quantity entered by the customer
                if (quantity.HasValue)
                {
                    XmlElement attributeValueQuantity = xmlDoc.CreateElement("Quantity");
                    attributeValueQuantity.InnerText = quantity.ToString();
                    _ = attributeValueElement.AppendChild(attributeValueQuantity);
                }

                result = xmlDoc.OuterXml;
            }
            catch (Exception exc)
            {
                Console.Write(exc.ToString());
            }

            return result;
        }

        /// <summary>
        /// Gets product attribute mappings by product identifier
        /// </summary>
        /// <param name="productId">The product identifier</param>
        /// <returns>Product attribute mapping collection</returns>
        public virtual IList<ProductProductAttributeMapping> GetProductAttributeMappingsByProductId(int productId)
        {
            IQueryable<ProductProductAttributeMapping> query = from pam in _context.ProductProductAttributeMappings
                                                               orderby pam.DisplayOrder, pam.Id
                                                               where pam.ProductId == productId
                                                               select pam;

            List<ProductProductAttributeMapping> attributes = query.ToList();

            return attributes;
        }

        /// <summary>
        /// Gets product attribute values by product attribute mapping identifier
        /// </summary>
        /// <param name="productAttributeMappingId">The product attribute mapping identifier</param>
        /// <returns>Product attribute mapping collection</returns>
        public virtual IList<ProductAttributeValue> GetProductAttributeValues(int productAttributeMappingId)
        {

            IQueryable<ProductAttributeValue> query = from pav in _context.ProductAttributeValues
                                                      orderby pav.DisplayOrder, pav.Id
                                                      where pav.ProductAttributeMappingId == productAttributeMappingId
                                                      select pav;
            List<ProductAttributeValue> productAttributeValues = query.ToList();

            return productAttributeValues;
        }

        #endregion complimentary methods

        #region main endpoint return methods
        public IList<ApiProduct> GetAllProducts()
        {

            IEnumerable<ApiProduct> query = (from p in _context.Products
                                             where p.Published == true
                                             where p.Deleted == false

                                             select new ApiProduct
                                             {
                                                 Id = p.Id,
                                                 ProductId = p.Id,
                                                 Imagename = p.ProductPictureMappings.Select(x => x.Picture.SeoFilename).FirstOrDefault(),//pic.Picture.SeoFilename,
                                                 Prodpicid = p.ProductPictureMappings.Select(x => x.Picture.Id).FirstOrDefault(),
                                                 Pname = p.Name,
                                                 IsNewProduct = p.MarkAsNew,
                                                 HasAttributes = p.ProductProductAttributeMappings.Any(pid => pid.ProductId == p.Id),
                                                 Imagetype = p.ProductPictureMappings.Select(x => x.Picture.MimeType).FirstOrDefault(),
                                                 ShortDescription = p.ShortDescription,
                                                 FullDescription = p.FullDescription,
                                                 Price = p.Price,
                                                 Oldprice = p.OldPrice,
                                                 Currency = _context.Currencies.Where(pub => pub.Published == true).Select(cucode => cucode.CurrencyCode).FirstOrDefault(),
                                                 ApprovedRatingSum = p.ApprovedRatingSum,

                                             }).ToList().GroupBy(pid => pid.ProductId).Select(s => s.First());//.OrderBy(q=>Guid.NewGuid());

            return query.ToList().OrderBy(q => Guid.NewGuid()).ToList();
        }


        //Gets a product  and ll its details in length

        public ApiProduct Getaproduct(int Id)
        {
            if (Id == 0)
            {
                return null;
            }

            IEnumerable<ApiProduct> query = from p in _context.Products
                                            where p.Id == Id
                                            where p.Published == true
                                            where p.Deleted == false

                                            select new ApiProduct
                                            {
                                                Id = Id,
                                                ProductId = p.Id,
                                                Imagename = p.ProductPictureMappings.Select(x => x.Picture.SeoFilename).FirstOrDefault(),//pic.Picture.SeoFilename,
                                                Prodpicid = p.ProductPictureMappings.Select(x => x.Picture.Id).FirstOrDefault(),
                                                Pname = p.Name,
                                                HasAttributes = p.ProductProductAttributeMappings.Any(pid => pid.ProductId == p.Id),
                                                Imagetype = p.ProductPictureMappings.Select(x => x.Picture.MimeType).FirstOrDefault(),
                                                ShortDescription = p.ShortDescription,
                                                FullDescription = p.FullDescription,
                                                Price = p.Price,
                                                SeoPname = _context.UrlRecords.Where(ent => ent.EntityId == p.Id && ent.EntityName == "Product").Select(seoname => seoname.Slug).FirstOrDefault(),
                                                Uri = _context.Stores.Where(str => str.SslEnabled == true).Select(sturl => sturl.Url).FirstOrDefault(),
                                                Oldprice = p.OldPrice,
                                                Currency = _context.Currencies.Where(pub => pub.Published == true).Select(cucode => cucode.CurrencyCode).FirstOrDefault(),
                                                ApprovedRatingSum = p.ApprovedRatingSum,
                                                Images = p.ProductPictureMappings.Select(x => x.Picture).ToList(),
                                                Reviews = p.ProductReviews.ToList(),
                                                Attributes = _context.ProductAttributeValues.
                                                Where(map => map.ProductAttributeMapping.ProductId == p.Id).Select(attrs =>
                                                new ApiProductAttributes
                                                {
                                                    Id = attrs.Id,
                                                    AttId = attrs.Id,
                                                    Mappingid = attrs.ProductAttributeMappingId,
                                                    AttributesValue = attrs.Name,
                                                    Baseattribute = attrs.ProductAttributeMapping.ProductAttribute.Name
                                                }).ToList(),


                                            };

            return query.FirstOrDefault();
        }

        //gets product to be reviewed
        public Product GetThisProd(int Id)
        {
            if (Id < 0)
            {
                return null;
            }

            IQueryable<Product> selected = from repo in _context.Products
                                           where repo.Id == Id
                                           select repo;
            return selected.FirstOrDefault();
        }

        public List<ApiProduct> GetMobileCartItem(int userid, int carttype)
        {
            IEnumerable<ApiProduct> cartproducts = (from p in _context.Products
                                                    join cart in _context.ShoppingCartItems on p.Id equals cart.ProductId
                                                    where cart.CustomerId == userid && cart.ShoppingCartTypeId == carttype
                                                    select new ApiProduct
                                                    {
                                                        Id = p.Id,
                                                        ProductId = p.Id,
                                                        Imagename = p.ProductPictureMappings.Select(x => x.Picture.SeoFilename).FirstOrDefault(),//pic.Picture.SeoFilename,
                                                        Prodpicid = p.ProductPictureMappings.Select(x => x.Picture.Id).FirstOrDefault(),
                                                        Pname = p.Name,
                                                        HasAttributes = p.ProductProductAttributeMappings.Any(pid => pid.ProductId == p.Id),
                                                        Imagetype = p.ProductPictureMappings.Select(x => x.Picture.MimeType).FirstOrDefault(),
                                                        ShortDescription = p.ShortDescription,
                                                        FullDescription = p.FullDescription,
                                                        OrderProdAttributeXML = cart.AttributesXml,
                                                        Price = p.Price,
                                                        Oldprice = p.OldPrice,
                                                        Currency = _context.Currencies.Where(pub => pub.Published == true).Select(cucode => cucode.CurrencyCode).FirstOrDefault(),
                                                        ApprovedRatingSum = p.ApprovedRatingSum,
                                                        Quantity = p.ShoppingCartItems.Where(cart => cart.CustomerId == userid && cart.ProductId == p.Id && cart.ShoppingCartTypeId == carttype).FirstOrDefault().Quantity

                                                    }).ToList().GroupBy(pid => pid.ProductId).Select(s => s.First());

            return cartproducts.ToList();
        }



        public IList<ApiProduct> GetProdByCategoryId(int subCategoryId)
        {
            IEnumerable<ApiProduct> prods = (from p in _context.Products
                                             join cat in _context.ProductCategoryMappings on p.Id equals cat.ProductId
                                             where cat.CategoryId == subCategoryId
                                             where p.Published == true
                                             where p.Deleted == false
                                             select new ApiProduct
                                             {
                                                 Id = p.Id,
                                                 ProductId = p.Id,
                                                 Imagename = p.ProductPictureMappings.Select(x => x.Picture.SeoFilename).FirstOrDefault(),//pic.Picture.SeoFilename,
                                                 Prodpicid = p.ProductPictureMappings.Select(x => x.Picture.Id).FirstOrDefault(),
                                                 Pname = p.Name,
                                                 HasAttributes = p.ProductProductAttributeMappings.Any(pid => pid.ProductId == p.Id),
                                                 Imagetype = p.ProductPictureMappings.Select(x => x.Picture.MimeType).FirstOrDefault(),
                                                 ShortDescription = p.ShortDescription,
                                                 FullDescription = p.FullDescription,
                                                 Price = p.Price,
                                                 Oldprice = p.OldPrice,
                                                 Currency = _context.Currencies.Where(pub => pub.Published == true).Select(cucode => cucode.CurrencyCode).FirstOrDefault(),
                                                 ApprovedRatingSum = p.ApprovedRatingSum,
                                                 Reviews = p.ProductReviews.ToList()

                                             }).ToList().GroupBy(pid => pid.ProductId).Select(s => s.First());

            return prods.ToList();
        }

        public virtual IList<ApiCategory> GetCategories()
        {
            List<ApiCategory> categories = new();
            //get subcategories
            // if (categoryid != 0 || categoryid > 0)
            // {
            IQueryable<ApiCategory> subcategory = from Ca in _context.Categories
                                                  where Ca.ParentCategoryId > 0
                                                  where Ca.Published == true
                                                  let catimage = (from pic in _context.Pictures
                                                                  where
                             pic.Id == Ca.PictureId

                                                                  select pic).FirstOrDefault()
                                                  select new ApiCategory

                                                  {
                                                      Name = Ca.Name,
                                                      Description = Ca.Description,
                                                      Id = Ca.Id,
                                                      PictureId = Ca.PictureId,
                                                      CategoryIconName = catimage.SeoFilename,
                                                      CategoryIconFormat = catimage.MimeType

                                                  };

            return subcategory.ToList();
        }

        /// <summary>
        /// Inserts a product review
        /// </summary>
        /// <param name="productReview">Product review</param>
        public virtual void InsertProductReview(ProductReview productReview)
        {
            if (productReview == null)
            {
                throw new ArgumentNullException(nameof(productReview));
            }

            _ = _context.ProductReviews.Add(productReview);
            _ = _context.SaveChanges();

            //event notification
            //_eventPublisher.EntityInserted(productReview);
        }
        /// <summary>
        /// Update product review totals
        /// </summary>
        /// <param name="product">Product</param>
        public virtual void UpdateProductReviewTotals(Product product)
        {
            if (product == null)
            {
                throw new ArgumentNullException(nameof(product));
            }

            int approvedRatingSum = 0;
            int notApprovedRatingSum = 0;
            int approvedTotalReviews = 0;
            int notApprovedTotalReviews = 0;

            IQueryable<ProductReview> reviews = _context.ProductReviews.Where(r => r.ProductId == product.Id);
            foreach (ProductReview pr in reviews)
            {
                if (pr.IsApproved)
                {
                    approvedRatingSum += pr.Rating;
                    approvedTotalReviews++;
                }
                else
                {
                    notApprovedRatingSum += pr.Rating;
                    notApprovedTotalReviews++;
                }
            }

            product.ApprovedRatingSum = approvedRatingSum;
            product.NotApprovedRatingSum = notApprovedRatingSum;
            product.ApprovedTotalReviews = approvedTotalReviews;
            product.NotApprovedTotalReviews = notApprovedTotalReviews;
            _ = _context.SaveChanges();
        }
        #endregion main return methods
        #endregion
    }
}
