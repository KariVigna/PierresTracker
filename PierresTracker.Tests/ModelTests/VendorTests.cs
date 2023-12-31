using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierresTracker.Models;
using System;

namespace PierresTracker.Tests
{
    [TestClass]
    public class VendorTests : IDisposable
    {
        public void Dispose()
        {
            Vendor.ClearAll();
        }
        
        [TestMethod]
        public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
        {
            Vendor newVendor = new Vendor("Suzie's Cafe");
            Assert.AreEqual(typeof(Vendor), newVendor.GetType());
        }

        [TestMethod]
        public void GetName_ReturnsVendorName_String()
        {
            string name = "Suzie's Cafe";
            Vendor newVendor = new Vendor(name);
            string result = newVendor.Name;
            Assert.AreEqual(name, result);
        }

        [TestMethod]
        public void GetId_ReturnsVendorId_Int()
        {
            string name = "Suzie's Cafe";
            Vendor newVendor = new Vendor(name);
            int result = newVendor.Id;
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void GetAll_ReturnsAllVendorObjects_VendorList()
        {
            string name1 = "Suzie's Cafe";
            string name2 = "Bagel Boys";
            Vendor newVendor1 = new Vendor(name1);
            Vendor newVendor2 = new Vendor(name2);
            List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };
            List<Vendor> result = Vendor.GetAll();
            CollectionAssert.AreEqual(newList, result);
        }

        [TestMethod]
        public void Find_ReturnsCorrectVendor_Vendor()
        {
            string name1 = "Suzie's Cafe";
            string name2 = "Bagel Boys";
            Vendor newVendor1 = new Vendor(name1);
            Vendor newVendor2 = new Vendor(name2);
            Vendor result = Vendor.Find(1);
            Assert.AreEqual(newVendor1, result);
        }

        [TestMethod]
        public void AddOrder_AssociatesOrderWithVendor_OrderList()
        {
            string description = "Bagels";
            Order newOrder = new Order(description);
            List<Order> newList = new List<Order> { newOrder };
            string name = "Suzie's Cafe";
            Vendor newVendor = new Vendor(name);
            newVendor.AddOrder(newOrder);
            List<Order> result = newVendor.Orders;
            CollectionAssert.AreEqual(newList, result);
        }
    }
}