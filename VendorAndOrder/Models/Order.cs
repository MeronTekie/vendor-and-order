using System.Collections.Generic;

namespace VendorAndOrder.Models
{
  public class Order
  {
    private static List<Order> _instances = new List<Order> {};
    public string Name { get; set; }
    public int Id { get; }
    public List<Order> Items { get; set; }

    public Order(string OrderName)
    {
      Name = OrderName;
      _instances.Add(this);
      Id = _instances.Count;
      Items = new List<Order>{};
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

    public void AddItem(Order item)
    {
      Items.Add(item);
    }

  }
}