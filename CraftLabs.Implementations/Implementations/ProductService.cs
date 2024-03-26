using CraftLabs.DataAccess.Implementations.Contracts;
using CraftLabs.Implementations.Contracts.Contracts;
using CraftLabs.Models;

namespace CraftLabs.Implementations.Implementations
{
    public class ProductService : IProductService
    {
        private IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            this._productRepository = productRepository;
        }

        public List<Product> GetAll()
        {
            return _productRepository.GetAll().ToList();
        }

        public List<Product> GetDiscountedProducts()
        {
            var discountProducts = _productRepository.GetAll()
                .Where(p => p.Category == "Golosinas")
                .ToList();

            return discountProducts;
        }
    }
}
