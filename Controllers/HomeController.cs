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
    List<Places> allPlaces = new List<Places> {};
    return View();
  }

  [HttpPost("/home_page")]
  public ActionResult VisitedPlaces()
  {
    Places newPlace = new Places(Request.Form["location"], Request.Form["date"]);
    newPlace.Save();
    List<Places> allPlaces = Places.GetAll();
    return View("VisitedPlaces", allPlaces);
  }

  }
}
