using Nop.RestApi.Service.Db;
using Nop.RestApi.Service.Models.Catalogue;
using Nop.RestApi.Service.Models.core;
using System;
using System.Linq;

namespace Nop.RestApi.Service.Services.Catalogue
{
    public class CartService : ICartService
    {
        #region fields
        private readonly ApiContext _context;
        #endregion fields

        #region ctor
        public CartService(ApiContext apiContext)
        {
            _context = apiContext;
        }
        #endregion ctor


        #region methods

        //method handled addd/delete/update for wishlist and shopping cart
        //carttypeid only separates wishlist and shopping cart items
        public virtual void AddToCart(ApiCart shoppingCartItem)
        {
            ShoppingCartItem current = _context.ShoppingCartItems.
                                Where(cart => cart.ProductId == shoppingCartItem.ProductId &&
                                //cart.AttributesXml == shoppingCartItem.AttributesXml &&
                                cart.CustomerId == shoppingCartItem.CustomerId &&
                                cart.ShoppingCartTypeId == shoppingCartItem.ShoppingCartTypeId)
                           .FirstOrDefault();

            ShoppingCartItem incoming = new()
            {
                ShoppingCartTypeId = shoppingCartItem.ShoppingCartTypeId,
                StoreId = shoppingCartItem.StoreId,
                ProductId = shoppingCartItem.ProductId,
                AttributesXml = shoppingCartItem.AttributesXml,
                CustomerEnteredPrice = shoppingCartItem.CustomerEnteredPrice,
                Quantity = shoppingCartItem.Quantity,
                RentalStartDateUtc = shoppingCartItem.RentalStartDateUtc,
                RentalEndDateUtc = shoppingCartItem.RentalEndDateUtc,
                CreatedOnUtc = shoppingCartItem.CreatedOnUtc,
                UpdatedOnUtc = shoppingCartItem.UpdatedOnUtc,
                CustomerId = shoppingCartItem.CustomerId
            };

            //existing item. update quantity and updated date

            if (current != null && shoppingCartItem.IsFavorite == true)
            {
                current.Quantity += incoming.Quantity;
                current.UpdatedOnUtc = DateTime.UtcNow;

            }
            //existing product has been removed from wishlist/cart. delete it from db
            else if (current != null && shoppingCartItem.IsFavorite == false)
            {
                _ = _context.ShoppingCartItems.Attach(current);
                _ = _context.ShoppingCartItems.Remove(current);
            }

            //new item. insert new cart item
            else
            {
                _ = current == null && shoppingCartItem.IsFavorite == true
                    ? _context.ShoppingCartItems.Add(incoming)
                    : throw new Exception("Unknown request format. Check parameters and try again");
                // _context.SaveChanges();
            }
            _ = _context.SaveChanges();
        }
        #endregion methods
    }
}
