using System.Web.Mvc;

namespace ProductApp.Web.Controllers.api
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult List()
        {
            return View();
        }

        public ActionResult Add()
        {
            return View();
        }
    }
}