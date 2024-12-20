using Microsoft.AspNetCore.Mvc;
using xuong_moc.Areas.Customers.Models;

namespace xuong_moc.Areas.Customers.Controllers
{
    public class AccountController : Controller
    {
        // GET: Customer/Account/Register
        public ActionResult Register()
        {
            return View();
        }

        // POST: Customer/Account/Register
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(UserModel model)
        {
            if (ModelState.IsValid)
            {
                // Logic để lưu thông tin người dùng vào cơ sở dữ liệu (giả sử bạn đang sử dụng một database)
                // Có thể sử dụng một service để lưu user vào database hoặc lưu vào session để kiểm thử

                // Sau khi lưu thành công, chuyển hướng đến trang login
                return RedirectToAction("Login");
            }

            return View(model);
        }

        // GET: Customer/Account/Login
        public ActionResult Login()
        {
            return View();
        }

        // POST: Customer/Account/Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(UserModel model)
        {
            if (ModelState.IsValid)
            {
                // Kiểm tra thông tin đăng nhập (thông thường sẽ kiểm tra với cơ sở dữ liệu)
                // Giả sử người dùng luôn đăng nhập thành công
                if (model.LoginUsername == "test" && model.LoginPassword == "password")
                {
                    // Sau khi đăng nhập thành công, chuyển hướng đến trang Index của Customer
                    return RedirectToAction("Index", "Customer", new { area = "Customer" });
                }
                else
                {
                    ModelState.AddModelError("", "Invalid login attempt.");
                }
            }

            return View(model);
        }
    }
}
