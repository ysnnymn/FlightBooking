using FlightBooking.Services.FlightServices;
using FllightBooking.Dtos.FlightDtos;
using Microsoft.AspNetCore.Mvc;

namespace FllightBooking.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class FlightsController : Controller
    {
        private readonly IFlightService _flightservice;
        // GET: FlightsController
        public FlightsController(IFlightService flightservice)
        {
            _flightservice = flightservice;
        }

        public async Task<IActionResult> FlightList()
        {
            var values=await _flightservice.GetAllFlightsAsync();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateFlight()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateFlight(CreateFlightDto createFlightDto)
        {
            await _flightservice.CreateFlightAsync(createFlightDto);
            return RedirectToAction("FlightList");
        }

    }
}
