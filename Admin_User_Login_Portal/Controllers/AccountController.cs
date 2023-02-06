using Admin_User_Login_Portal.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace Admin_User_Login_Portal.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginViewModel Model)
        {
            if(Model.Username =="user@gmail.com"&&Model.Password=="12345678")
            {
                TempData["message"] = "Welcome Back!";
                string struser = JsonSerializer.Serialize(Model);
                HttpContext.Session.SetString("User",struser);
                return RedirectToAction("Index", "Home", new { area = "User" }); 
            }
            else if(Model.Username == "admin@gmail.com" && Model.Password == "12345678")
            { TempData["message"] = "Welcome Back!";
                string stradmin = JsonSerializer.Serialize(Model);
                HttpContext.Session.SetString("Admin", stradmin);
                return RedirectToAction("Index", "Home", new { area = "Admin" }); }
            ViewBag.ErrorMessage = "Username and Password doesn't exist!";
            return View();
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return View();
        }
        public IActionResult Signup()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Signup(Userviewmodel model)
        {
            if(ModelState.IsValid) {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
    }
}
