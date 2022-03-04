using System.Collections.Generic;

namespace VendorAndOrder.Models
{
  public class Order
  {
    public string OrderName { get; set; }
    public string OrderDate { get; set; }
    public string ProductType { get; set; }
    public int OrderCost { get; set; }
    public string OrderDescription { get; set; }

    public Order(string orderName, string orderDate, string productType, int orderCost, string orderDescription)
    {
      OrderName = orderName;
      OrderDate = orderDate;
      ProductType = productType;
      OrderCost = orderCost;
      OrderDescription = orderDescription;
    }
  }
}