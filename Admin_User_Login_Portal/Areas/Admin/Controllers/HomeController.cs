using Microsoft.AspNetCore.Mvc;

namespace Admin_User_Login_Portal.Areas.Admin.Controllers
{
    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
