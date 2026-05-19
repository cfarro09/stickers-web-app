using Microsoft.AspNetCore.Mvc;

namespace StickersWebApp.Controllers;

public class AdminController : Controller
{
    public IActionResult Settings()
    {
        if (Request.Headers.ContainsKey("HX-Request"))
        {
            return PartialView();
        }
        return View();
    }

    public IActionResult Users()
    {
        if (Request.Headers.ContainsKey("HX-Request"))
        {
            return PartialView();
        }
        return View();
    }
}
