using Microsoft.AspNetCore.Mvc;

namespace FllightBooking.ViewComponents.DefaultViewComponents;

public class _DefaultSliderComponentPartial:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
    
}