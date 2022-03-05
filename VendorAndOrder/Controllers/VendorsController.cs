using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using VendorAndOrder.Models;

namespace VendorAndOrder.Controllers
{
  public class VendorsController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> vendorList = Vendor.GetAll();
      return View(vendorList);
    }
    [HttpGet("/vendors/add")]
    public ActionResult Add()
    {
      return View();
    }
    [HttpPost("/vendors")]
    public ActionResult Create(string vendorName, string vendorDescription)
    {
      Vendor newVendor = new Vendor(vendorName, vendorDescription);
      return RedirectToAction("Index");
    }
    [HttpGet("/vendors/{id}")]
    public ActionResult Show(int Id)
    {
      Vendor vendor = Vendor.Find(Id);
      return View(vendor);
    }
    [HttpPost("/vendors/{Id}/orders")]
    public ActionResult Create(int vendorId, string orderName, string orderDate, string productType, int orderCost, string orderDescription)
    {
      Order newOrder = new Order(orderName, orderDate, productType, orderCost, orderDescription);
      Vendor currentVendor = Vendor.Find(vendorId);
      currentVendor.AddOrder(newOrder);
      // Dictionary<string, object> returnableDictionary = new Dictionary<string, object>();
      // returnableDictionary.Add("vendor", currentVendor);
      // returnableDictionary.Add("order);
      return View("Show", currentVendor);
    }
  }
}
