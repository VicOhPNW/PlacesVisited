using System.Collections;
using System.Collections.Generic;

namespace PlacesVisited.Models
{
  public class Places
  {
    private string _location;
    private string _date;
    private static List<Places> _instances = new List<Places> {};

    public Places(string location, string date)
    {
      _location = location;
      _date = date;
    }

    public void SetLocation(string location)
    {
      _location = location;
    }
    public string GetLocation()
    {
      return _location;
    }
    public void SetDate(string date)
    {
      _date = date;
    }
    public string GetDate()
    {
      return _date;
    }
    public void Save()
    {
      _instances.Add(this);
    }
    public static List<Places> GetAll()
    {
      return _instances;
    }
  }
}
