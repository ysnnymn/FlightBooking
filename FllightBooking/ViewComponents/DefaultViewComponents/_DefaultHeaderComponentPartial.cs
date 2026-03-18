using Microsoft.AspNetCore.Mvc;

namespace FllightBooking.ViewComponents.DefaultViewComponents;

public class _DefaultHeaderComponentPartial:ViewComponent
{

    public IViewComponentResult Invoke()
    {
        return View();
    }
}