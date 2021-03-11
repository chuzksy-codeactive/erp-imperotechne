using Microsoft.AspNetCore.Mvc;

namespace JPSAGE_ERP.WebAPI.Controllers
{
    public class NotificationsController : Controller
    {
        public IActionResult EmailConfirmed(string userId, string normalToken)
        {
            if (string.IsNullOrWhiteSpace(userId) || string.IsNullOrWhiteSpace(normalToken))
            {
                return Redirect("/login");
            }

            return View();
        }
    }
}
