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
    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      string vendor01 = "Suzie Bakery";
      string vendor02 = "Porrtland Coffee shop";
      string vendor03 = "Seattle Restaurant";
      Vendor newVendor01 = new Vendor(vendor01, "Pizzeria and Fastfood");
      Vendor newVendor02 = new Vendor(vendor02, "Coffee shop");
      Vendor newVendor03 = new Vendor(vendor03, "Restaurant");
      List<Vendor>newList = new List<Vendor> { newVendor01, newVendor02 ,newVendor03};
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      string vendor01 = "Suzie Bakery";
      string vendor02 = "Porrtland Coffee shop";
      string vendor03 = "Seattle Restaurant";
      Vendor newVendor01 = new Vendor(vendor01, "Pizzeria and Fastfood");
      Vendor newVendor02 = new Vendor(vendor02, "Coffee shop");
      Vendor newVendor03 = new Vendor(vendor03, "Restaurant");
      List<Vendor>newList = new List<Vendor> { newVendor01, newVendor02 ,newVendor03};
    
      Vendor result = Vendor.Find(2);
      Assert.AreEqual(newVendor02, result);
    }
    [TestMethod]
    public void AddItem_AssociatesItemWithVendor_OrderList()
    {
      int price = 78;
      Order newOrder = new Order("name","title",price, 1, "1");
      List<Order> newList = new List<Order> { newOrder };
      string vendor01 = "Suzie Bakery";
      Vendor newVendor = new Vendor(vendor01, "Pizzeria and Fastfood");
      newVendor.AddOrder(newOrder);
      List<Order> result = newVendor.Orders;
      CollectionAssert.AreEqual(newList, result);
    }
        [TestMethod]
    public void Getdescription_ReturnsDescripton_String()
    {
      string vendor01 = "Suzie Bakery";
      string description = "Pizzeria and Fastfood";
      Vendor newVendor = new Vendor(vendor01, description);
      Vendor nextVendor = new Vendor("Porrtland Coffee shop", "Coffee shop");
      string nameResult = newVendor.VendorName;
      string descriptionResult = newVendor.Description;
      Assert.AreEqual(vendor01, nameResult);
      Assert.AreEqual(description, descriptionResult);

    }

  }
}
