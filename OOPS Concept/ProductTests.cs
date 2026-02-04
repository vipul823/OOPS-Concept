using NUnit.Framework;
using System.Collections.Generic;

namespace OOPS_Concept
{
    [TestFixture]
    public class ProductTests
    {
        [Test]
        public void TestGroupByCategory()
        {
            List<Product> products = new List<Product>
            {
                new Product("Laptop", 500, "Electronics"),
                new Product("Phone", 95, "Electronics"),
                new Product("Shirt", 180, "Clothing")
            };

            Dictionary<string, List<Product>> groupedProducts = Product.GroupProductsByCategory(products);

            Assert.That(groupedProducts.Count, Is.EqualTo(2));
            Assert.That(groupedProducts.ContainsKey("Clothing"), Is.True);
            Assert.That(groupedProducts["Electronics"].Count, Is.EqualTo(2));
        }
    }
}
