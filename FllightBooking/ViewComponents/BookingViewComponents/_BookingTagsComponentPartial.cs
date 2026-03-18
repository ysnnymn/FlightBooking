using Microsoft.AspNetCore.Mvc;

namespace FllightBooking.ViewComponents.BookingViewComponents;

public class _BookingTagsComponentPartial:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
    
}