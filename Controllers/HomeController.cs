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
    List <Places> allPlaces = Places.GetAll();
    return View(allPlaces);
  }
  [HttpGet("/Home/Index/{id}")]
  public ActionResult Details(int id)
  {
    Places place= Places.Find(id);
    return View(place);
  }

  [HttpPost("/Visited/{id}")] //Alters
  public ActionResult VisitedPlaces()
  {
    Places newPlaces = new Places(Request.Form["location"], Request.Form["date"]);
    List <Places> allPlaces = Places.GetAll();
    // newPlaces.Save();
    return View("/Index", allPlaces);
  }
  }
}
