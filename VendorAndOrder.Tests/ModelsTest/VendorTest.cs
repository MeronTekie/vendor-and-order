using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorAndOrder.Models;
using System;
namespace VendorAndOrder.Tests
{
  [TestClass]
  public class Tests
  {
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("Vendor", " Its a bakery");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
  }
}
