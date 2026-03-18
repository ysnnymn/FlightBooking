using Microsoft.AspNetCore.Mvc;

namespace FllightBooking.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LayoutController : Controller
    {
        // GET: LayoutController
        public ActionResult AdminLayout()
        {
            return View();
        }

    }
}
