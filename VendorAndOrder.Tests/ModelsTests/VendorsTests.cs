using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorAndOrder.Models;
using System;

namespace VendorAndOrder.Tests
{
  [TestClass]
  public class VendorsTests
  {
    [TestMethod]
    public void CategoryConstructor_CreatesInstanceOfCategory_Category()
    {
      Vendor newVendor = new Vendor("Safeway");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
  }
}
