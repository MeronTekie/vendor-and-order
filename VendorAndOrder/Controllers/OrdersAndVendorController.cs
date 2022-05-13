using Microsoft.AspNetCore.Mvc;

namespace VendorAndOrder.Controllers
{
  public class OrdersAndVendorController : Controller
  {
    [HttpGet("/OrdersAndVendor")]
    public ActionResult New() 
    { 
      return View();
    }

  }
}