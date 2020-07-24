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
      Vendor newVendor = new Vendor("VooDoo", "Donuts");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      //Arrange
      string vendorDescription = "Bakery";
      string name = "Test Vendor";
      Vendor newVendor = new Vendor(name, vendorDescription);

      //Act
      string result = newVendor.Name;

      //Assert
      Assert.AreEqual(name, result);
    }
  
    [TestMethod]
      public void GetId_ReturnsVendorId_Int()
      {
        //Arrange
        string vendorDescription = "Bakery";
        string name = "Test Vendor";
        Vendor newVendor = new Vendor(name, vendorDescription);

        //Act
        int result = newVendor.Id;

        //Assert
        Assert.AreEqual(1, result);
      }

        [TestMethod]
      public void GetAll_ReturnsAllVendorObjects_VendorList()
      {
        //Arrange
        string vendorDescription = "Bakery";
        string name01 = "Roses";
        string name02 = "VooDoo";
        Vendor newVendor1 = new Vendor(name01, vendorDescription);
        Vendor newVendor2 = new Vendor(name02, vendorDescription);
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
        string vendorDescription = "Bakery";
        string name01 = "Roses";
        string name02 = "VooDoo";
        Vendor newVendor1 = new Vendor(name01, vendorDescription);
        Vendor newVendor2 = new Vendor(name02, vendorDescription);

        //Act
        Vendor result = Vendor.Find(2);

        //Assert
        Assert.AreEqual(newVendor2, result);
      }

      [TestMethod]
      public void AddOrder_AssociatesOrderWithVendor_OrderList()
      {
        //Arrange
        string vendorDescription = "Bakery";
        string date = "Saturday";
        string price= "100";
        string description = "Donuts";
        Order newOrder = new Order(description, date, price );
        List<Order> newList = new List<Order> { newOrder };
        string name = "Roses";
        Vendor newVendor = new Vendor(name, vendorDescription);
        newVendor.AddOrder(newOrder);

        //Act
        List<Order> result = newVendor.Orders;

        //Assert
        CollectionAssert.AreEqual(newList, result);
      }
  
  
  
  }
}