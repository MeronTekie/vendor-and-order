using Microsoft.AspNetCore.Mvc;
using VendorAndOrder.Models;

namespace VendorAndOrder.Controllers
{
  public class VendorController : Controller
  {
    [Route("/vendor/new")]
    public ActionResult New()
    {
      return View();
    }
   
    
  }
}