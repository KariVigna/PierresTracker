using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierresTracker.Models;
using System;

namespace PierresTracker.Tests
{
    [TestClass]
    public class OrderTests
    {

        [TestMethod]
        public void OrderConstructor_CreatesInstanceOfOrder_Order()
        {
            Order newOrder = new Order("test");
            Assert.AreEqual(typeof(Order), newOrder.GetType());
        }
    }
}