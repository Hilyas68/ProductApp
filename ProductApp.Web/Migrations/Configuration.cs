namespace ProductApp.Web.Migrations
{
    using ProductApp.Web.Models;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<ProductApp.Web.Data.ProductDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ProductApp.Web.Data.ProductDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.


            var products = DummyProducts.GetProductList();
            context.Set<Product>().AddRange(products);
            context.SaveChanges();

        }
    }
}
