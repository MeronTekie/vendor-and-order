using System.Collections.Generic;

namespace VendorAndOrder.Models
{
  public class Order
  {
    private static List<Order> _instances = new List<Order> {};
    private static int _PricePerCake = 3;
  
    public string Name { get; set; }
    public string Title  { get; set;}
    public int TotalPrice{ get; set; }
    public int PhoneNumber{get; set;}
    public string Date{get;set;}
    public int Id { get; }
    public List<Order> Orders { get; set; }
    public Order(string name,string title ,int totalprice,int phonenumber,string date)

    {
      Name =name;
      Title= title;
      TotalPrice =totalprice * _PricePerCake;
      PhoneNumber =phonenumber;
      Date =date;
      _instances.Add(this);
      Id = _instances.Count;      
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static List<Order> GetAll()
    {
      return _instances;
    }
    public static Order Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}