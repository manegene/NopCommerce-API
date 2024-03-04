using Nop.RestApi.Service.Db;
using Nop.RestApi.Service.Models.Catalogue;
using System.Collections.Generic;

namespace Nop.RestApi.Service.Services.Catalogue
{
    public interface IProductService
    {
        #region complimentary methods

        /// <summary>
        /// Adds an attribute
        /// </summary>
        /// <param name="attributesXml">Attributes in XML format</param>
        /// <param name="productAttributeMapping">Product attribute mapping</param>
        /// <param name="value">Value</param>
        /// <param name="quantity">Quantity (used with AttributeValueType.AssociatedToProduct to specify the quantity entered by the customer)</param>
        /// <returns>Updated result (XML format)</returns>
        string AddProductAttribute(string attributesXml, ProductProductAttributeMapping productAttributeMapping, string value, int? quantity = null);
        IList<ProductProductAttributeMapping> GetProductAttributeMappingsByProductId(int productId);
        IList<ProductAttributeValue> GetProductAttributeValues(int productAttributeMappingId);


        #endregion complimentary methods
        //get all products 
        IList<ApiProduct> GetAllProducts();



        //Get a product by its id
        ApiProduct Getaproduct(int Id);

        //get wishlist items
        /*IList<ApiProduct> GetMobileWishItem(int userid);
        */
        //get products in the cart
        List<ApiProduct> GetMobileCartItem(int userid, int carttype);

        //get products grouped by selected category
        IList<ApiProduct> GetProdByCategoryId(int subCategoryId);

        //List of all categories
        IList<ApiCategory> GetCategories();

        void InsertProductReview(ProductReview productReview);

        void UpdateProductReviewTotals(Product product);
        Product GetThisProd(int Id);


    }
}
