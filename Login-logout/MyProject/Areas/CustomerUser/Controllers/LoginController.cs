﻿using Microsoft.AspNetCore.Mvc;
using MyProject.Areas.CustomerUser.Models;
using MyProject.Models;

namespace MyProject.Areas.CustomerUser.Controllers
{
    [Area("CustomerUser")]
    public class LoginController : Controller
    {
        public MyProjectContext _context;
        public LoginController(MyProjectContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost] // POST -> khi submit form
        public IActionResult Index(LoginUser model)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError(string.Empty, "Thông tin đăng nhập không hợp lệ.");
                return View(model);
            }

            var pass = model.Password;
            var dataLogin = _context.Users.FirstOrDefault(x => x.Email.Equals(model.Email) && x.Password.Equals(pass));
            if (dataLogin != null)
            {
                ViewBag.IsLoggedIn = true;
                HttpContext.Session.SetString("CustomerLogin", model.Email);
                HttpContext.Session.SetInt32("CustomerId", dataLogin.UserId);
                return RedirectToAction("Index", "Dashboard", new {userId = dataLogin.UserId});
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Thông tin đăng nhập không chính xác.");
                return View(model);
            }

        }
        [HttpGet]// thoát đăng nhập, huỷ session
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("CustomerLogin"); // huỷ session với key AdminLogin đã lưu trước đó

            return RedirectToAction("Index");
        }

    }
}
