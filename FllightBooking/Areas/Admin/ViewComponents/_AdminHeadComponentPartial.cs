using Microsoft.AspNetCore.Mvc;

namespace FllightBooking.Areas.Admin.ViewComponents;

public class _AdminHeadComponentPartial:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
    
}