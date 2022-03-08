using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BEL;
using DAL;

namespace BLL
{
    public class EmployeeService
    {
        public static UserModel GetEmpInfo(int id)
        {
            var config = new MapperConfiguration(c =>
              {
                  c.CreateMap<User, UserModel>();
                  c.CreateMap<UserModel, User>();
                  c.CreateMap<Employee, EmployeeModel>();
                  c.CreateMap<EmployeeModel, Employee>();
              });
            var mapper = new Mapper(config);
            var data = mapper.Map<UserModel>(DataAccessFactory.EmployeeDataAccess().Get(id));
            return data;
        }
        public static List<Order_DetailsModel> getAssignedWorks(int id)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Order, OrderModel>();
                c.CreateMap<OrderModel, Order>();
                c.CreateMap<User, UserModel>();
                c.CreateMap<UserModel, User>();
                c.CreateMap<Service, ServiceModel>();
                c.CreateMap<ServiceModel, Service>();
                c.CreateMap<Order_Details, Order_DetailsModel>();
                c.CreateMap<Order_DetailsModel, Order_Details>();
            });
            var mapper = new Mapper(config);
            var data= mapper.Map<List<Order_DetailsModel>>( DataAccessFactory.OrderDelailsDataAccess().GetDetails(id));
            return data;
        }
        public static List<Order_DetailsModel> getCompletedWorks(int id)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Order, OrderModel>();
                c.CreateMap<User, UserModel>();
                c.CreateMap<UserModel, User>();
                c.CreateMap<Order_Details, Order_DetailsModel>();
                c.CreateMap<Order_DetailsModel, Order_Details>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<List<Order_DetailsModel>>(DataAccessFactory.CompletedWorkDataAccess().GetDetails(id));
            return data;
        }
        //get wallet info
        public static int getWalletBalance(int id)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Order, OrderModel>();
                c.CreateMap<User, UserModel>();
                c.CreateMap<UserModel, User>();
                c.CreateMap<Order_Details, Order_DetailsModel>();
                c.CreateMap<Order_DetailsModel, Order_Details>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<List<Order_DetailsModel>>(DataAccessFactory.CompletedWorkDataAccess().GetDetails(id));

            var amount = 0;
            foreach (var line in data)
            {
                amount = (int)(amount + (@line.quantity * @line.unit_price));
            }
            return amount;
        }
        public static ServiceModel getServiceInfo(int id)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Service, ServiceModel>();
                
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<ServiceModel>(DataAccessFactory.ServiceDelailsDataAccess().Get(id));
            return data;
        }
        //employee's service catagory
        public static EmployeeModel getEmpServiceInfo(int id)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Service, ServiceModel>();
                c.CreateMap<ServiceModel, Service>();
                c.CreateMap<EmployeeModel, Employee>();
                c.CreateMap<Employee, EmployeeModel>();
                c.CreateMap<User, UserModel>();
                c.CreateMap<UserModel, User>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<EmployeeModel>(DataAccessFactory.WorkStatusDataAccess().Get(id));
            return data;
        }
        public static OrderModel GetCustomerInfo(int id)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<User, UserModel>();
                c.CreateMap<UserModel, User>();
                c.CreateMap<Order, OrderModel>();
                c.CreateMap<OrderModel, Order>();
                c.CreateMap<Employee, EmployeeModel>();
                c.CreateMap<EmployeeModel, Employee>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<OrderModel>(DataAccessFactory.OrderDataAccess().GetCustomerInfo(id));
            
            return data;
        }
        //change assign work to completed
        public static void ChangeWorkStatus(int id)
        {
            DataAccessFactory.OrderDataAccess().Edit(id);
        }
        //check application history
        public static List<ApplicationModel> ApplicationHistory(int id)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<ApplicationModel, Application>();
                c.CreateMap<Application, ApplicationModel>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<List<ApplicationModel>>(DataAccessFactory.ApplicationDataAccess().GetDetails(id));

            return data;
        }
        //send new applicaion
        public static void SendApplication(ApplicationModel s)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<ApplicationModel, Application>();
                c.CreateMap<Application, ApplicationModel>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Application>(s);
            DataAccessFactory.ApplicationDataAccess().Add(data);
        }
        public static void EditProfile(UserModel s)
        {
            
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<UserModel, User>();
                c.CreateMap<User, UserModel>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<User>(s);
            
            
            DataAccessFactory.EmployeeDataAccess().EditInfo(data);
        }
        //change employee status active or inavtive
        public static EmployeeModel ChangeActivityStatus(string status,int id)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Service, ServiceModel>();
                c.CreateMap<ServiceModel, Service>();
                c.CreateMap<EmployeeModel, Employee>();
                c.CreateMap<Employee, EmployeeModel>();
                c.CreateMap<User, UserModel>();
                c.CreateMap<UserModel, User>();

            });
            var mapper = new Mapper(config);
            var data=mapper.Map<EmployeeModel>(DataAccessFactory.WorkStatusDataAccess().ChangeWorkStatus(status,id));
            return data;
        }
    }
}
