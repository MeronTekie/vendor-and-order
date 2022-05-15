using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorAndOrder.Models;
using System;
namespace VendorAndOrder.Tests
{
  [TestClass]
  public class VendorTests:IDisposable
  {
     public void Dispose()
    {
      Vendor.ClearAll();
    }
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("Vendor", " Its a bakery");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
    [TestMethod]
    public void VendorName_ReturnsName_String()
    {
      string vendor = "Suzie Bakery";
      Vendor newVendor = new Vendor(vendor, "Pizzeria and Fastfood");
      string result = newVendor.VendorName;
      Assert.AreEqual(vendor, result);
    }
     [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      string vendor = "Suzie Bakery";
      Vendor newVendor = new Vendor(vendor, "Pizzeria and Fastfood");
      int result = newVendor.Id;
      Assert.AreEqual(1, result);
    }
  }
}
