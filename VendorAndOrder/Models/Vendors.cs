using System.Collections.Generic;

namespace VendorAndOrder.Models
{
  public class Vendor
  {
    public string VendorName { get; set; }
    public int Id { get; }
    public List<Order> Orders { get; set; }

    public Vendor(string vendorName)
    {
      VendorName = vendorName;

    }
  }
}