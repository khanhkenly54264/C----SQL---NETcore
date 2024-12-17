using Microsoft.AspNetCore.Mvc;

namespace xuong_moc.Areas.Admins.Controllers
{
    public class DashboardController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
