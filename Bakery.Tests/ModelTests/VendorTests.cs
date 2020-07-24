using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System.Collections.Generic;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class VendorTest : IDisposable
  {

    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      //Arrange
      string name = "Test Vendor";
      Vendor newVendor = new Vendor(name);

      //Act
      string result = newVendor.Name;

      //Assert
      Assert.AreEqual(name, result);
    }
  
    [TestMethod]
      public void GetId_ReturnsVendorId_Int()
      {
        //Arrange
        string name = "Test Vendor";
        Vendor newVendor = new Vendor(name);

        //Act
        int result = newVendor.Id;

        //Assert
        Assert.AreEqual(1, result);
      }

        [TestMethod]
      public void GetAll_ReturnsAllVendorObjects_VendorList()
      {
        //Arrange
        string name01 = "Roses";
        string name02 = "VooDoo";
        Vendor newVendor1 = new Vendor(name01);
        Vendor newVendor2 = new Vendor(name02);
        List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };

        //Act
        List<Vendor> result = Vendor.GetAll();

        //Assert
        CollectionAssert.AreEqual(newList, result);
      }

      [TestMethod]
      public void Find_ReturnsCorrectVendor_Vendor()
      {
        //Arrange
        string name01 = "Roses";
        string name02 = "VooDoo";
        Vendor newVendor1 = new Vendor(name01);
        Vendor newVendor2 = new Vendor(name02);

        //Act
        Vendor result = Vendor.Find(2);

        //Assert
        Assert.AreEqual(newVendor2, result);
      }
  
  
  
  }
}