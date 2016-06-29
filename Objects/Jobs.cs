using System.Collections.Generic;

namespace Jobs.Objects
{
  public class Job
  {
    private string _jobName;
    private string _started;
    private string _ended;
    private string _location;
    private string _duties;
    private static List<string> _instances = new List<string> {};

    public Job (string jobName, string started, string ended, string location, string duties)
    {
      _jobName = jobName;
      _started = started;
      _ended = ended;
      _location = location;
      _duties = duties;
    }
    public string GetJobName()
    {
      return _jobName;
    }
    public void SetJobName(string newJobName)
    {
      _jobName = newJobName;
    }
    public string GetStarted()
    {
      return _started;
    }
    public void SetStarted(string newStarted)
    {
      _started = newStarted;
    }
    public string GetEnded()
    {
      return _ended;
    }
    public void SetEnded(string newEnded)
    {
      _ended = newEnded;
    }
    public string GetLocation()
    {
      return _location;
    }
    public void SetLocation(string newLocation)
    {
      _location = newLocation;
    }
    public string GetDuties()
    {
      return _duties;
    }
    public void SetDuties(string newDuties)
    {
      _duties = newDuties;
    }
    public static List<string> GetAll()
    {
      return _instances;
    }
    public void Save()
    {
      _instances.Add("job title: " + _jobName + ". From " + _started + " to " + _ended + ". Location: " + _location + ". Duties: " + _duties);
    }
  }
}
