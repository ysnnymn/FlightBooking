using Microsoft.AspNetCore.Mvc;

namespace FllightBooking.ViewComponents.BookingViewComponents;

public class _BookingAreaComponentPartial:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
    
}