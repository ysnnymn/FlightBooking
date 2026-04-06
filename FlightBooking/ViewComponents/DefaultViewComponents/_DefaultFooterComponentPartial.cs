using Microsoft.AspNetCore.Mvc;

namespace FllightBooking.ViewComponents.DefaultViewComponents;

public class _DefaultFooterComponentPartial:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
    
}