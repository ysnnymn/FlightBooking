using Microsoft.AspNetCore.Mvc;

namespace FllightBooking.Areas.Admin.ViewComponents;

public class _AdminTopbarComponentPartial:ViewComponent 
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}