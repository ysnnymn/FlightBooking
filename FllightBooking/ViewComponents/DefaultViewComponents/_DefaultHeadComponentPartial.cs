using Microsoft.AspNetCore.Mvc;

namespace FllightBooking.ViewComponents.DefaultViewComponents;

public class _DefaultHeadComponentPartial:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}