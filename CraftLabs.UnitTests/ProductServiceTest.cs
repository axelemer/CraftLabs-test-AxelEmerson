using CraftLabs.DataAccess.Implementations.Contracts;
using CraftLabs.DataAccess.Implementations.Repositories;
using CraftLabs.Implementations.Implementations;
using CraftLabs.Models;
using Moq;

namespace CraftLabs.UnitTests
{
    public class ProductServiceTest
    {
        private ProductService productService;
        private Mock<ProductRepository> repository;

        private List<Product> products = new List<Product>()
        {};

        [SetUp]
        public void Setup()
        {
            repository = new Mock<ProductRepository>();
            productService = new ProductService(repository.Object);
        }

        [Test]
        public void GetProductsReturnsOneProduct()
        {
            //Arrange
            Product product = new()
            {
                Id = 1,
                Name = "Test",
            };
            products.Add(product);

            var productsQuery = products.AsQueryable();
            repository.Setup(repository => repository.GetAll()).Returns(productsQuery);

            //Act
            var result = productService.GetAll();

            //Assert
            Assert.That(result, Is.Not.Null);
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual(result.FirstOrDefault(), product);
        }
    }
}