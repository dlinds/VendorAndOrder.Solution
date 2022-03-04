using System.Collections.Generic;

namespace VendorAndOrder.Models
{
  public class Order
  {
    public int OrderCount { get; set; }
    public string ProductType { get; set; }

    public Order(int orderCount, string productType)
    {
      OrderCount = orderCount;
      ProductType = productType;
    }
  }
}