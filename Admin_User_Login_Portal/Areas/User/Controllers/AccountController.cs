using Microsoft.AspNetCore.Mvc;

namespace Admin_User_Login_Portal.Areas.User.Controllers
{
    public class AccountController : BaseController
    {
        public IActionResult Profile()
        {
            return View();
        }
    }
}
