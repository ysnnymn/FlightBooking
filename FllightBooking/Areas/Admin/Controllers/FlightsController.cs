using Microsoft.AspNetCore.Mvc;

namespace FllightBooking.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class FlightsController : Controller
    {
        // GET: FlightsController
        public ActionResult FlightList()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CreateFlight()
        {
            return View();
        }

    }
}
