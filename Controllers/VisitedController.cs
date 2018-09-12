using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PlacesVisited.Models;

namespace PlacesVisited.Controllers
{
  public class VisitedController : Controller
  {
    [HttpGet("/Visited")]
    public ActionResult Index()
    {
      List <Places> allPlaces = Places.GetAll();
      return View(allPlaces);
    }

    [HttpGet("/Visited/{id}")] //Requests
    public ActionResult VisitedPlaces(int id)
    {
      Places newPlace = Places.Find(id);
      return View(newPlace);
    }

    [HttpGet("/Visited/add")]
    public ActionResult Save()
    {
      return View();
    }

    


  }
}
