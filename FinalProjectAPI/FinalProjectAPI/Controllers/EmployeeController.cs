using BLL;
using BEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using FinalProjectAPI.Auth;

namespace FinalProjectAPI.Controllers
{
    [EnableCors("*","*","*")]
    public class EmployeeController : ApiController
    {
        //employee profile
        [CustomAuth]
        [Route("api/Employee/Profile")]
        [HttpGet]
        public UserModel getInfo(int id)
        {
            var data= EmployeeService.GetEmpInfo(id);
            return data;
        }
        //view assign work list
        
        [Route("api/Employee/AssignWorks")]
        [HttpGet]
        public List<Order_DetailsModel> getAssignedWorks(int id)
        {
            return EmployeeService.getAssignedWorks(id);
        }
        //get employee's service catagory
        
        [CustomAuth]
        [Route("api/Employee/Service/Catagory")]
        [HttpGet]
        public EmployeeModel getEmpServiceINfo(int id)
        {
            return EmployeeService.getEmpServiceInfo(id);
        }
        //service info
        
        [CustomAuth]
        [Route("api/Employee/Assign/ServiceInfo")]
        [HttpGet]
        public ServiceModel getServiceINfo(int id)
        {
            return EmployeeService.getServiceInfo(id);
        }
        
        //assign service customer info
        [CustomAuth]
        [Route("api/Order/ServiceDetails")]
        [HttpGet]
        public OrderModel getCustomerINfo(int id)
        {
            return EmployeeService.GetCustomerInfo(id);
        }
        //change assign work status ordered to completes
        
        [Route("api/Employee/AssignWork/ChangeStatus")]
        [HttpGet]
        public void ChangeWorkDone(int id)
        {
            EmployeeService.ChangeWorkStatus(id);
        }
        //see completed work
        
        [CustomAuth]
        [Route("api/Employee/CompletedWork")]
        [HttpGet]
        public List<Order_DetailsModel> getCompletedWorks(int id)
        {
            return EmployeeService.getCompletedWorks(id);
        }
        //view wallet

        [CustomAuth]
        [Route("api/Employee/wallet")]
        [HttpGet]
        public int getWaletBalance(int id)
        {
            return EmployeeService.getWalletBalance(id);
        }
        [CustomAuth]
        [Route("api/Employee/Application/Histrory")]
        [HttpGet]
        public List<ApplicationModel> GetApplicationHistory(int id)
        {
            return EmployeeService.ApplicationHistory(id);
        }
        //send application request
        [CustomAuth]
        [Route("api/Employee/Application/Send")]
        [HttpPost]
        public void PostSendApplication(ApplicationModel s)
        {
            
            EmployeeService.SendApplication(s);
        }
        
        [CustomAuth]
        [Route("api/Employee/Profile/Edit")]
        [HttpPost]
        public void PostProfileEdit(UserModel s)
        {
            EmployeeService.EditProfile(s);
        }
        
        [CustomAuth]
        [Route("api/Employee/WorkStatus/Change")]
        [HttpGet]
        public EmployeeModel getChangeWorkStatus(string status,int id)
        {
            return EmployeeService.ChangeActivityStatus(status,id);
        }

        [CustomAuth]
        [Route("api/view/application")]
        [HttpGet]
        public bool ViewPage()
        {
            return true;
        }
    }
}
