using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using VendorAndOrder.Models;

namespace VendorAndOrder.Controllers
{
  public class OrdersController : Controller
  {
    [HttpGet("/vendors/{id}/orders/add")]
    public ActionResult Add()
    {
      return View();
    }
  }
}