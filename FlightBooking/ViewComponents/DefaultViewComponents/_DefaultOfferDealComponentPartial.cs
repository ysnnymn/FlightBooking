using Microsoft.AspNetCore.Mvc;

namespace FllightBooking.ViewComponents.DefaultViewComponents;

public class _DefaultOfferDealComponentPartial:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
    
}