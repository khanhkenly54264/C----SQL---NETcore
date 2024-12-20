using Microsoft.AspNetCore.Mvc;

namespace xuong_moc.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
