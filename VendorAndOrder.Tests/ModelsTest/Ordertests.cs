using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorAndOrder.Models;
using System;

namespace VendorOrder.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {

    public void Dispose()
    {
    Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order( "Yagneh","FAstFood", 80, 1, "01/05/2022");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]
    public void GetPrice_ReturnsTotalPRICE_Int()
    {
      int PriceperCake =3;
      int price = 80 ;
      Order newOrder = new ( "Yagneh","FastFood", price, 1, "01/05/2022");
      int result = newOrder.TotalPrice;
      price *= PriceperCake;
      Assert.AreEqual(price, result);
    }

    [TestMethod]
    public void SetTitle_ReturnsSetTitle_String()
    {
      string title = "FastFood";
      Order newOrder = new Order( "Yagneh",title, 80, 2060000000, "01/05/2022");
      string updatedTitle = "Pizzeria";
      newOrder.Title = updatedTitle;
      string result = newOrder.Title;
      Assert.AreEqual(updatedTitle, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      
      List<Order> newList = new List<Order> { };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsItems_OrderList()
    {
      string name01 = "Seattle";
      string name02 = "Portland";
      Order newOrder1 = new Order(name01, "FastFood",80,2060000000, "05/05/2022");
      Order newOrder2 = new Order(name02, "Bakery",3500,2060000000, "05/05/2022");
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void GetPropertiesOfObject_ReturnsPropertiesOfObject_StringAndIntegers()
    {
      string name = "Seattle";
      string title = "FastFood";
      int phonenumber =2060000000;
      int price = 35;
      int PriceperCake =3;
      price*=PriceperCake;
      string date = "05/05/2022";
      Order newOrder = new Order(name,title,  35,phonenumber, date);
      Order nextOrder = new Order(name, "FastFood",35,2060000000, "05/06/2022");
      
      string nameResult = newOrder.Name;
      string titleResult = newOrder.Title;
      int priceResult = newOrder.TotalPrice;
      int phonenumberResult =newOrder.PhoneNumber;
      string dateResult = newOrder.Date;
      Assert.AreEqual(title, titleResult);
      Assert.AreEqual(phonenumber, phonenumberResult);
      Assert.AreEqual(price, priceResult);
      Assert.AreEqual(date, dateResult);
    }
  }
}