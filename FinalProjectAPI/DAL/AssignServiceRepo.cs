using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AssignServiceRepo:IRepository<Order_Details,int, string>
    {
        Service_Entities db;
        public AssignServiceRepo(Service_Entities db)
        {
            this.db = db;
        }

        public void Add(Order_Details e)
        {
            throw new NotImplementedException();
        }

        public Order_Details ChangeWorkStatus(string e, int id)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(int id)
        {
            throw new NotImplementedException();
        }

        public void EditInfo(Order_Details e)
        {
            throw new NotImplementedException();
        }

        public List<Order_Details> Get()
        {
            throw new NotImplementedException();
        }

        public Order_Details Get(int id)
        {
            throw new NotImplementedException();
        }

        public Order_Details GetCustomerInfo(int id)
        {
            throw new NotImplementedException();
        }

        public List<Order_Details> GetDetails(int id)
        {
            var e = (from d in db.Order_Details
                     where d.employee_id == id && d.Order.status == "ordered"
                     select d).ToList();
            return e;

        }
    }
}
