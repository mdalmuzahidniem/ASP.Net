using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class OrderStatusRepo : IRepository<Order, int, string>
    {

        Service_Entities db;
        public OrderStatusRepo(Service_Entities db)
        {
            this.db = db;
        }
        public void Add(Order e)
        {
            throw new NotImplementedException();
        }

        public Order ChangeWorkStatus(string e, int id)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(int id)
        {
            var e = (from o in db.Orders
                     where o.id == id
                     select o).FirstOrDefault();
            e.status = "completed";
            db.SaveChanges();
        }

        public void EditInfo(Order e)
        {
            throw new NotImplementedException();
        }

        public List<Order> Get()
        {
            throw new NotImplementedException();
        }

        public Order Get(int id)
        {
            throw new NotImplementedException();
        }

        public Order GetCustomerInfo(int id)
        {
            return db.Orders.FirstOrDefault(e => e.id == id);
        }

        public List<Order> GetDetails(int id)
        {
            throw new NotImplementedException();
        }
    }
}
