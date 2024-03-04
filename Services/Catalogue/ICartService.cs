using Nop.RestApi.Service.Models.Catalogue;

namespace Nop.RestApi.Service.Services.Catalogue
{
    public interface ICartService
    {
        void AddToCart(ApiCart shoppingCartItem);
    }
}
