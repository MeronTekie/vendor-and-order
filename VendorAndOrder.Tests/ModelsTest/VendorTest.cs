using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorAndOrder.Models;
using System;
namespace VendorAndOrder.Tests
{
  [TestClass]
  public class VendorTests
  {
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
      Vendor newVendor = new Vendor(vendor, "test description");
      string result = newVendor.VendorName;
      Assert.AreEqual(vendor, result);
    }
  }
}
