using Microsoft.AspNetCore.Mvc;
using Nop.RestApi.Service.Controllers.Core;
using Nop.RestApi.Service.Db;
using Nop.RestApi.Service.Models.Catalogue;
using Nop.RestApi.Service.Services.Catalogue;
using System;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Nop.RestApi.Service.Controllers.Catalogue
{
    public class ProductsController : BaseAuthController
    {
        #region fields
        private readonly IProductService _apiproductsService;

        #endregion fields

        #region ctor
        public ProductsController(
             IProductService productsService)
        {
            _apiproductsService = productsService;
        }
        #endregion ctor

        #region endpoints

        // GET: api/<ProductsController>
        [HttpGet]
        public IEnumerable<ApiProduct> Get()
        {
            IList<ApiProduct> Allproducts = _apiproductsService.GetAllProducts();//_apiproductsService.GetAllProducts();
            return Allproducts;
        }

        // GET api/<ProductsController>/5
        [HttpGet("{id}")]
        public ApiProduct Get(int id)
        {
            if (id < 0)
            {
                return null;
            }
            ApiProduct SelectedProduct = _apiproductsService.Getaproduct(id);
            return SelectedProduct;
        }

        //get products by category id
        [HttpGet]
        [Route("Getprodbycategoryid")]
        public ActionResult<IList<ApiProduct>> GetProdByCategoryId(int subCategoryId)
        {
            IList<ApiProduct> categoryprods = _apiproductsService.GetProdByCategoryId(subCategoryId);
            return Ok(categoryprods);
        }
        /*
        //Gets all categories and sub categories based on category id
        Its not necessary to have the main/parent categories since products are not assigned to that 
        group. only subcategoeris that have products
        */
        [HttpGet]
        [Route("categories")]
        public ActionResult<IList<ApiCategory>> GetCategories()
        {
            IList<ApiCategory> categories = _apiproductsService.GetCategories();
            return categories == null ? (ActionResult<IList<ApiCategory>>)BadRequest() : (ActionResult<IList<ApiCategory>>)Ok(categories);
        }

        //post product reviews
        [HttpPost]
        [Route("addreview")]
        public ActionResult AddReview(ApiReview apireview)
        {
            if (apireview == null)
            {
                throw new Exception("cant submit empty revie");
            }

            int prodid = apireview.ProdId;

            Product product = _apiproductsService.GetThisProd(prodid);
            bool isApproved = true;
            int storedid = 1;
            ProductReview productReview = new()
            {
                ProductId = prodid,
                CustomerId = apireview.UserId,
                Title = apireview.Title,
                ReviewText = apireview.ReviewText,
                Rating = apireview.Rating,
                HelpfulYesTotal = 0,
                HelpfulNoTotal = 0,
                IsApproved = isApproved,
                CreatedOnUtc = DateTime.UtcNow,
                StoreId = storedid
            };

            _apiproductsService.InsertProductReview(productReview);

            _apiproductsService.UpdateProductReviewTotals(product);

            return Ok();
        }

        #endregion endpoints
    }
}
