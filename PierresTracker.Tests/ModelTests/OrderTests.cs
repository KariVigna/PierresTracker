using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierresTracker.Models;
using System;

namespace PierresTracker.Tests
{
    [TestClass]
    public class OrderTests : IDisposable
    {
        public void Dispose()
        {
            Order.ClearAll();
        }

        [TestMethod]
        public void OrderConstructor_CreatesInstanceOfOrder_Order()
        {
            Order newOrder = new Order("test");
            Assert.AreEqual(typeof(Order), newOrder.GetType());
        }

        [TestMethod]
        public void GetId_OrdersInstantiateWithAnId_Int()
        {
            string description = "Cookies";
            Order newOrder = new Order(description);
            int result = newOrder.Id;
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void GetAll_ReturnsOrders_OrderList()
        {
            string description1 = "Cookies";
            string description2 = "Bagels";
            Order newOrder1 = new Order(description1);
            Order newOrder2 = new Order(description2);
            List<Order> newList = new List<Order> { newOrder1, newOrder2 };
            List<Order> result = Order.GetAll();
            CollectionAssert.AreEqual(newList, result);
        }

        [TestMethod]
        public void Find_ReturnsCorrectItem_Item()
        {
            string description1 = "Cookies";
            string description2 = "Bagels";
            Order newOrder1 = new Order(description1);
            Order newOrder2 = new Order(description2);
            Order result = Order.Find(2);
            Assert.AreEqual(newOrder2, result);
        }
    }
}