using System;
using System.Collections.Generic;

namespace OOPS_Concept
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }

        public Product(string name, decimal price, string category)
        {
            Name = name;
            Price = price;
            Category = category;
        }

        public static Dictionary<string, List<Product>> GroupProductsByCategory(List<Product> products)
        {
            Dictionary<string, List<Product>> groupedData = new Dictionary<string, List<Product>>();

            if (products == null)
                return groupedData;

            foreach (Product product in products)
            {
                if (!groupedData.ContainsKey(product.Category))
                {
                    groupedData[product.Category] = new List<Product>();
                }

                groupedData[product.Category].Add(product);
            }

            return groupedData;
        }
    }
}
