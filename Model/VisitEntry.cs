using System.Collections;
using System.Collections.Generic;

namespace PlacesVisited.Models
{
  public class Places
  {
    private string _location;
    private string _date;
    private int _id;
    private static List<Places> _instances = new List<Places> {};

    public Places(string location, string date)
    {
      _location = location;
      _date = date;
      _instances.Add(this);
      _id = _instances.Count;
    }
    public int GetId()
    {
      return _id;
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
    public static void ClearAll()
    {
      _instances.Clear();
    }
     public static Places Find (int searchId)
    {
      return _instances[searchId-1];
    }
  }
}
