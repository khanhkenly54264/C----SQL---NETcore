using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using xuong_moc.Areas.CustomerA.Models;
using System.Linq;
using xuong_moc.Models;

namespace xuong_moc.Areas.CustomerA.Controllers
{
    [Area("CustomerA")]
    public class CustomerLoginController : Controller
    {
        private readonly DevXuongMocContext _context;

        public CustomerLoginController(DevXuongMocContext context)
        {
            _context = context;
        }

        // GET: CustomerLogin/Index
        public IActionResult Index()
        {
            return View();
        }

        // POST: CustomerLogin/Index (Xử lý đăng nhập)
        [HttpPost]
        public IActionResult Index(CustomerLogin model)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError(string.Empty, "Thông tin đăng nhập không hợp lệ.");
                return View(model);
            }

            // Kiểm tra thông tin đăng nhập từ cơ sở dữ liệu
            var dataLogin = _context.Customers
                .Where(c => c.Email == model.Email && c.Password == model.Password)
                .FirstOrDefault();

            if (dataLogin != null)
            {
                // Lưu thông tin vào Session
                HttpContext.Session.SetString("CustomerLogin", model.Email);

                // Điều hướng tới Dashboard hoặc trang khác sau khi đăng nhập thành công
                return RedirectToAction("Index", "Dashboard", new { area = "CustomerA" });
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Email hoặc mật khẩu không chính xác.");
                return View(model);
            }
        }

        // GET: CustomerLogin/Logout (Đăng xuất)
        [HttpGet]
        public IActionResult Logout()
        {
            // Xóa Session
            HttpContext.Session.Remove("CustomerLogin");
            HttpContext.Session.Remove("CustomerId");

            // Điều hướng về trang đăng nhập
            return RedirectToAction("Index", "CustomerLogin", new { area = "CustomerA" });
        }
    }
}
