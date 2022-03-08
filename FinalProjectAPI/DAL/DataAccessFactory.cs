using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        static Service_Entities db;
        static DataAccessFactory()
        {
            db = new Service_Entities();
        }
        public static IRepository<User,int, string> EmployeeDataAccess()
        {
            return new EmployeeRepo(db);
        }
        public static IRepository<Order_Details, int, string> OrderDelailsDataAccess()
        {
            return new AssignServiceRepo(db);
        }
        public static IRepository<Service, int, string> ServiceDelailsDataAccess()
        {
            return new ServiceRepo(db);
        }
        public static IRepository<Order, int, string> OrderDataAccess()
        {
            return new OrderStatusRepo(db);
        }
        public static IRepository<Order_Details, int, string> CompletedWorkDataAccess()
        {
            return new CompletedWorkRepo(db);
        }
        public static IRepository<Application, int, string> ApplicationDataAccess()
        {
            return new ApplicationRepo(db);
        }
        public static IRepository<Employee, int, string> WorkStatusDataAccess()
        {
            return new WorkStatusRepo(db);
        }
        public static IAuth AuthDataAccess()
        {
            return new EmployeeRepo(db);
        }
    }
}
