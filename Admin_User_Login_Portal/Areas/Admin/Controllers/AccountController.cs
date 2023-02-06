using Microsoft.AspNetCore.Mvc;

namespace Admin_User_Login_Portal.Areas.Admin.Controllers
{
    public class AccountController : BaseController
    {
        public IActionResult Profile()
        {
            return View();
        }
    }
}
