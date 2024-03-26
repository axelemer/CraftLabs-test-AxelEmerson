using CraftLabs.DataAccess.Implementations.Contracts;
using CraftLabs.Models;

namespace CraftLabs.DataAccess.Implementations.Repositories
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        private static List<Product> _products = new List<Product>()
        {
            new Product { Id = 1, Name = "Producto 1", Category = "Limpieza"},
            new Product { Id = 2, Name = "Producto 2", Category = "Golosinas"}
        };

        public override IQueryable<Product> GetAll()
        {
            return _products.AsQueryable();
        }
    }
}
