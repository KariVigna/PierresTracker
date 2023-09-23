using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using PierresTracker.Models;

namespace PierresTracker.Controllers
{
  public class VendorController : Controller
  {

    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }
  }
}