using Microsoft.AspNetCore.Mvc;
using PierresTracker.Models;
using System.Collections.Generic;

namespace PierresTracker.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

    }
}