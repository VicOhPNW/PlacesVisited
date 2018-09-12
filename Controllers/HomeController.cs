using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PlacesVisited.Models;

namespace PlacesVisited.Controllers
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
