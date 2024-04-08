using Products.Models;
namespace Unit_Testing
{
    public class Tests
    {
        List<Product> products = null;

        [SetUp]
        public void Setup()
        {
            products = new List<Product>()
            { new Product(1, "Potato", 25), new Product(2, "Carrot", 15), new Product(3, "Meat", 120) };
        }

        [Test]
        public void Comparer_Price()
        {
            var res = new List<Product>() { new Product(3, "Meat", 120), new Product(1, "Potato", 25),
            new Product(2, "Carrot", 15)};

            products.Sort(new Product_Compare_By_Price());
            
            for (int i = 0; i < res.Count; i++)
            {
                Assert.IsTrue(res[i].Equals(products[i]));
            }
        }

        [Test]
        public void Compare_Name()
        {
            var res = new List<Product>() { new Product(2, "Carrot", 15), new Product(3, "Meat", 120), new Product(1, "Potato", 25),
                };

            products.Sort(new Product_Compare_By_Name());

            for (int i = 0; i < res.Count; i++)
            {
                Assert.IsTrue(res[i].Equals(products[i]));
            }
        }   
    }
}