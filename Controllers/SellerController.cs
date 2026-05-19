using Microsoft.AspNetCore.Mvc;

namespace StickersWebApp.Controllers;

public class SellerController : Controller
{
    public IActionResult Index()
    {
        if (Request.Headers.ContainsKey("HX-Request"))
        {
            return PartialView();
        }
        return View();
    }

    public IActionResult History()
    {
        if (Request.Headers.ContainsKey("HX-Request"))
        {
            return PartialView();
        }
        return View();
    }
}
