using Microsoft.AspNetCore.Mvc;

namespace StickersWebApp.Controllers;

public class PrintingController : Controller
{
    public IActionResult Index()
    {
        if (Request.Headers.ContainsKey("HX-Request"))
        {
            return PartialView();
        }
        return View();
    }
}
