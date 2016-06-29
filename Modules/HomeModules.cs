using Nancy;
using System.Collections.Generic;
using Jobs.Objects;

namespace Jobs
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Post["/jobs"] = _ => {
        Job newJob = new Job (Request.Form["new-job"], Request.Form["new-started"], Request.Form["new-ended"], Request.Form["new-location"], Request.Form["new-duties"]);
        newJob.Save();
        List<string> AllJobs = Job.GetAll();
        return View["job_list.cshtml", AllJobs];
      };
      Get["/jobs"]= _ => {
        List<string> AllJobs = Job.GetAll();
        return View["job_list.cshtml", AllJobs];
      };
    }
  }
}
