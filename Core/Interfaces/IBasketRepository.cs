using System.Threading.Tasks;
using Core.Entities;

namespace Core.Interfaces
{
    public interface IBasketRepository
    {
         Task<CustomerBasket> GetBasketAsync(string basketId);
         Task<CustomerBasket> UpadateBasketAsync(CustomerBasket basket);
         Task<bool> DeleteBasketAsync(string basketId);
    }
}