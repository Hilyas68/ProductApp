using ProductApp.Web.Data;
using ProductApp.Web.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProductApp.Web.Repo
{
    public class ProductRepo : IRepository
    {
        private ProductDbContext productDbContext;
        public ProductRepo()
        {
            productDbContext = new ProductDbContext();
        }

        public void Add(Product product)
        {
            productDbContext.Set<Product>().Add(product);
            productDbContext.SaveChanges();
        }

        public IEnumerable<Product> GetProducts()
        {
            return productDbContext.Set<Product>().ToList();
        }
    }
}