using CraftLabs.Models;

namespace CraftLabs.DataAccess.Implementations.Contracts
{
    public interface IProductRepository
    {
        IQueryable<Product> GetAll();
    }
}
