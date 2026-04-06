using Microsoft.AspNetCore.Mvc;

namespace FllightBooking.ViewComponents.DefaultViewComponents;

public class _DefaultFlightStatusComponentPartial:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
    
}