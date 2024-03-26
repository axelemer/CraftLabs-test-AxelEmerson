using CraftLabs.Models;

namespace CraftLabs.Implementations.Contracts.Contracts
{
    public interface IProductService
    {
        List<Product> GetAll();

        List<Product> GetDiscountedProducts();
    }
}
