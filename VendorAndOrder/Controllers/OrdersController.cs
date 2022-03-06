using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using VendorAndOrder.Models;

namespace VendorAndOrder.Controllers
{
  public class OrdersController : Controller
  {
    [HttpGet("/vendors/{Id}/orders/add")]
    public ActionResult Add(int Id)
    {
      Dictionary<string, object> listOfOrders = new Dictionary<string, object>();
      Vendor vendor = Vendor.Find(Id);
      return View(vendor);
    }
    [HttpGet("/orders/add")]
    public ActionResult AddWithNoVendor()
    {
      List<Vendor> listOfVendors = Vendor.GetAll();
      return View("Add", listOfVendors);
    }
    [HttpGet("/orders")]
    public ActionResult Show()
    {
      List<Vendor> listOfVendors = Vendor.GetAll();
      return View(listOfVendors);
    }
  }
}