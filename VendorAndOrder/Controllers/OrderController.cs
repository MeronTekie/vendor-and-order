using Microsoft.AspNetCore.Mvc;
using VendorAndOrder.Models;

namespace Vendor.Controllers
{
  public class OrdersAndVendorController : Controller
  {
    [HttpPost("/OrdersAndVendor")]
    public ActionResult New() 
    { 
      return View();
    }

  }
}