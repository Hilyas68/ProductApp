using ProductApp.Web.Models;
using ProductApp.Web.Repo;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace ProductApp.Web.Controllers.api
{
    [RoutePrefix("api/product")]
    public class ProductApiController : ApiController
    {
        private ProductRepo productRepo;
        public ProductApiController()
        {
            productRepo = new ProductRepo();
        }

        [Route("add")]
        [HttpPost]
        public HttpResponseMessage AddProduct(Product p)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return this.Request.CreateResponse(HttpStatusCode.BadRequest, "your fields are not valid");
                }

                var addProduct = new Product { Name = p.Name, Description = p.Description, Price = p.Price };

                productRepo.Add(addProduct);

                return this.Request.CreateResponse(HttpStatusCode.Created, "Successful");
            }
            catch (Exception ex)
            {

                return this.Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }

        }

        [Route("list")]
        public HttpResponseMessage GetProducts()
        {

            try
            {
                IEnumerable<Product> products = productRepo.GetProducts();
                return this.Request.CreateResponse<IEnumerable<Product>>(HttpStatusCode.Created, products);
            }
            catch (Exception ex)
            {

                return this.Request.CreateResponse(HttpStatusCode.Created, ex.Message);
            }
        }


    }
}