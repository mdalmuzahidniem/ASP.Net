using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class WorkStatusRepo:IRepository<Employee,int,string>
    {
        Service_Entities db;
        public WorkStatusRepo(Service_Entities db)
        {
            this.db = db;
        }

        public void Add(Employee e)
        {
            throw new NotImplementedException();
        }

        public Employee ChangeWorkStatus(string status, int id)
        {
            var data = (from emp in db.Employees
                     where emp.id == id
                     select emp).FirstOrDefault();
            data.work_status = status;
            db.SaveChanges();
            var updateData = (from emp in db.Employees
                              where emp.id == id
                              select emp).FirstOrDefault();
            return updateData;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(int id)
        {
            throw new NotImplementedException();
        }

        public void EditInfo(Employee e)
        {
            throw new NotImplementedException();
        }

        public List<Employee> Get()
        {
            throw new NotImplementedException();
        }

        public Employee Get(int id)
        {
            var e = (from emp in db.Employees
                     where emp.id == id
                     select emp).FirstOrDefault();
            return e;
        }

        public Employee GetCustomerInfo(int id)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetDetails(int id)
        {
            throw new NotImplementedException();
        }
    }
}
