namespace CraftLabs.Models
{
    public class Product
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public string? Category { get; set; }

        public void Test() 
        {
            var a = new Product { Id = 1, Name = "test" };
            var b = a;

            Verify(ref b);
        }

        public void Verify(ref Product a)
        {
            a = new Product { Id = 2, Name = "pepe" };
        }
    }
}
