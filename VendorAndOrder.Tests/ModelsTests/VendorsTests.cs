using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorAndOrder.Models;
using System;

namespace VendorAndOrder.Tests
{
  [TestClass]
  public class VendorsTests : IDisposable
  {

    public void Dispose()
    {
      Vendor.ClearAll();
    }
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("Safeway");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
    [TestMethod]
    public void GetVendorName_ReturnsNameOfVendor_String()
    {
      Vendor newVendor = new Vendor("Safeway");
      Assert.AreEqual("Safeway", newVendor.VendorName);
    }
    [TestMethod]
    public void GetVendorID_ReturnsIDOfVendor_Int()
    {
      Vendor newVendor = new Vendor("Safeway");
      Assert.AreEqual(1, newVendor.Id);
    }
  }
}
