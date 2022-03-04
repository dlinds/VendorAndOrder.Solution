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
      Vendor newVendor = new Vendor("Safeway", "A Grocery Store");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
    [TestMethod]
    public void GetVendorName_ReturnsNameOfVendor_String()
    {
      Vendor newVendor = new Vendor("Safeway", "A Grocery Store");
      Assert.AreEqual("Safeway", newVendor.VendorName);
    }
    [TestMethod]
    public void GetVendorID_ReturnsIDOfVendor_Int()
    {
      Vendor newVendor = new Vendor("Safeway", "A Grocery Store");
      Assert.AreEqual(1, newVendor.Id);
    }
    [TestMethod]
    public void GetAll_ReturnsEmptyVendorList_List()
    {
      List<Vendor> emptyList = new List<Vendor> { };
      CollectionAssert.AreEqual(emptyList, Vendor.GetAll());
    }
    [TestMethod]
    public void GetAll_ReturnsVendorListWithOneVendor_List()
    {
      Vendor newVendor = new Vendor("Safeway", "A Grocery Store");
      List<Vendor> vendorList = new List<Vendor> { newVendor };
      CollectionAssert.AreEqual(vendorList, Vendor.GetAll());
    }
  }
}
