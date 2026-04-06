using Microsoft.AspNetCore.Mvc;

namespace FllightBooking.ViewComponents.DefaultViewComponents;

public class _DefaultNavbarComponentPartial:ViewComponent
{
    public IViewComponentResult Invoke()
    {
            return View();
    }
    
}