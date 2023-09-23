using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierresTracker.Models;
using System;

namespace PierresTracker.Tests
{
    [TestClass]
    public class VendorTests
    {

        [TestMethod]
        public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
        {
            Vendor newVendor = new Vendor("Suzie's Cafe");
            Assert.AreEqual(typeof(Vendor), newVendor.GetType());
        }
    }
}