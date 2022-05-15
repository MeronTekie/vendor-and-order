using Microsoft.AspNetCore.Mvc;

namespace HomeController.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index() 
    { 
      return View();
    }
  }
}