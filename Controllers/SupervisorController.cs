using Microsoft.AspNetCore.Mvc;

namespace StickersWebApp.Controllers;

public class SupervisorController : Controller
{
    public IActionResult Approvals()
    {
        if (Request.Headers.ContainsKey("HX-Request"))
        {
            return PartialView();
        }
        return View();
    }
}
