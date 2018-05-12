using ProductApp.Web.Models;
using System.Data.Entity;

namespace ProductApp.Web.Data
{
    public class ProductDbContext : DbContext
    {
        public DbSet<Product> products { get; set; }

        public ProductDbContext() : base($"name ={nameof(ProductDbContext)} ")
        {

        }
    }
}

