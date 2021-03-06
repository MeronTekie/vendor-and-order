using Microsoft.AspNetCore.Mvc;
using VendorAndOrder.Models;
using System;
using System.Collections.Generic;

namespace VendorAndOrder.Controllers
{
  public class VendorsController : Controller
  {
  [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> Vendors = Vendor.GetAll();
      return View(Vendors);
    }
    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }
    [HttpPost("/vendors")]
    public ActionResult Create(string vendorName, string vendorDescription)
    {
      Vendor newVendor = new Vendor(vendorName, vendorDescription);
      return RedirectToAction("Index");
    }
    [HttpGet("/vendors/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor selectedVendor = Vendor.Find(id);
      List<Order> vendorOrders = selectedVendor.Orders;
      model.Add("vendor", selectedVendor);
      model.Add("order", vendorOrders);
      return View(model);
    }
    [HttpPost("/vendors/{vendorId}/orders")]
    public ActionResult Create(int vendorId, string name,string title,int phonenumber, int totalprice, string date)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor findVendor = Vendor.Find(vendorId);
      Order newOrder = new Order( name,title,phonenumber,totalprice, date);
      findVendor.AddOrder(newOrder);
      List<Order> vendorOrders = findVendor.Orders;
      model.Add("order", vendorOrders);
      model.Add("vendor", findVendor);
      return View("Show", model);
    }
  }
}