using Microsoft.AspNetCore.Mvc;

namespace FllightBooking.ViewComponents.DefaultViewComponents;

public class _DefaultFrequantlyAskedQuestionComponentPartial:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
    
}