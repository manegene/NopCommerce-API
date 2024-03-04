using Microsoft.AspNetCore.Mvc;
using Nop.RestApi.Service.Controllers.Core;
using Nop.RestApi.Service.Db;
using Nop.RestApi.Service.Models.ApiUser;
using Nop.RestApi.Service.Models.Catalogue;
using Nop.RestApi.Service.Services.Catalogue;
using Nop.RestApi.Service.Services.CustomerServices;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Nop.RestApi.Service.Controllers.Catalogue
{
    public class CartController : BaseAuthController
    {
        #region fields
        private readonly IProductService _productService;
        private readonly ICustomerService _customerService;
        private readonly ICartService _cartService;
        #endregion fields

        #region ctor
        public CartController(IProductService productService,
            ICustomerService customerService,
            ICartService cartService)
        {
            _cartService = cartService;
            _customerService = customerService;
            _productService = productService;
        }
        #endregion ctor

        // GET customer cart items api/<HbmCart>/getcartitem?id
        [HttpPost]
        [Route("getcartitem")]
        public ActionResult<IList<ApiProduct>> GetCartItems(ApiWishorCart apiwishorCart)
        {
            if (apiwishorCart != null)
            {

                IList<ApiProduct> cart = _productService.GetMobileCartItem(apiwishorCart.Userid, apiwishorCart.CartType);
                return Ok(cart.ToList());

            }
            return BadRequest();
        }

        // add/update product to shoppingcart/wishlist items. Catch is on the carttype value api/<HbmCart>/addtocart
        [HttpPost]
        [Route("addtocart")]
        public virtual ActionResult AddProductToCart(ApiWishorCart apiWishorCart)
        {
            int cartType = apiWishorCart.CartType;
            Customer user = _customerService.GetCustomerById(apiWishorCart.Userid);
            int storeid = 1;
            int quantity = 1;
            Product product = _productService.GetThisProd(apiWishorCart.ProductId);
            string attxml = apiWishorCart.AttributesXML;
            DateTime now = DateTime.UtcNow;
            bool favorite = apiWishorCart.IsFavorite;

            if (product == null)
            {
                //no product found
                return BadRequest(new
                {
                    success = false,
                    message = "No product found with the specified ID"
                });
            }
            else if (user == null)
            {
                return BadRequest();
            }
            else
            {
                try
                {


                    ApiCart incoming = new()
                    {
                        ShoppingCartTypeId = cartType,
                        StoreId = storeid,
                        ProductId = product.Id,
                        AttributesXml = attxml,
                        CustomerEnteredPrice = 0,
                        Quantity = quantity,
                        RentalStartDateUtc = null,
                        RentalEndDateUtc = null,
                        CreatedOnUtc = now,
                        UpdatedOnUtc = now,
                        CustomerId = user.Id,
                        IsFavorite = favorite

                    };

                    _cartService.AddToCart(incoming);
                    return Ok(new
                    {
                        success = true,
                        message = "record updated successfully"
                    });
                }
                catch (Exception ex)
                {
                    return Content(ex.ToString());
                }
            }
        }

    }
}
