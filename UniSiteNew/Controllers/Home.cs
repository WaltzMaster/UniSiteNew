using Microsoft.AspNetCore.Mvc;

namespace UniSiteNew.Controllers;

public class Home : Controller
{
    // GET
    [HttpGet]
    [Route("/")]
    public IActionResult Index()
    {
        return View();
    }
}