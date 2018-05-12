using ProductApp.Web.Models;
using System.Collections.Generic;

namespace ProductApp.Web.Repo
{
    interface IRepository
    {
        IEnumerable<Product> GetProducts();
        void Add(Product product);
    }
}