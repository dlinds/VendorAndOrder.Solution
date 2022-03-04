using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorAndOrder.Models;
using System;

namespace VendorAndOrder.Tests
{
  [TestClass]
  public class OrdersTests
  {
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("Bread Order", "2022/03/04", "Bread", 5, "Order will be picked up in the evening");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]
    public void CheckOrderDetails_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("Bread Order", "2022/03/04", "Bread", 5, "Order will be picked up in the evening");
      Assert.AreEqual("Bread Order", newOrder.OrderName);
      Assert.AreEqual("2022/03/04", newOrder.OrderDate);
      Assert.AreEqual("Bread", newOrder.ProductType);
      Assert.AreEqual(5, newOrder.OrderCost);
      Assert.AreEqual("Order will be picked up in the evening", newOrder.OrderDescription);

    }
  }
}
