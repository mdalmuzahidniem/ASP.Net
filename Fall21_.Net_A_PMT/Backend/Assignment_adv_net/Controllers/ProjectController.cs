using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL;
using BLL.BEnt;
using System.Web.Http.Cors;

namespace Assignment_adv_net.Controllers
{
    [EnableCors("*","*","*")]
    public class ProjectController : ApiController
    {
        [Route("api/Project/all")]
        [HttpGet]
        public List<ProjectModel> GetAll()
        {
            return ProjectService.Get();
        }
        [Route("api/Project/open")]
        [HttpGet]
        public List<ProjectModel> GetAllOpenProject()
        {
            return ProjectService.Get("Open");
        }
        [Route("api/Project/Request")]
        [HttpGet]
        public List<AssignedProjectModel> GetAllRequest()
        {
            return ProjectService.GetRequest("Request");
        }
        [Route("api/Project/Create")]
        [HttpPost]
        public void Add(ProjectModel s)
        {
            ProjectService.Add(s);
        }
    }
}
