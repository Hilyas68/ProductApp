using System.Collections.Generic;

namespace ProductApp.Web.Models
{
    public static class DummyProducts
    {
        public static List<Product> GetProductList()
        {
            var category1 = new Category { Name = "Beverages" };
            var category2 = new Category { Name = "Fruits" };

            var ProductList = new List<Product>() {

            new Product
            {
                Name = "Milo",
               category = category1,
                Description = "This is a Milo",
                Price = 450
            },

           new Product
            {
                Name = "Bournvita",
                category = category1,
                Description = "This is a Bournvita",
                Price = 450
            },

             new Product
            {
                Name = "Orange",
                category = category2,
                Description = "This is an Orange",
                Price = 450
            },

              new Product
            {
                Name = "Apple",
               category = category2,
                Description = "This is an Apple",
                Price = 450
            }
        };

            return ProductList;
        }
    }
}