using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ServiceRepo : IRepository<Service, int, string>
    {
        Service_Entities db;
        public ServiceRepo(Service_Entities db)
        {
            this.db = db;
        }
        public void Add(Service e)
        {
            throw new NotImplementedException();
        }

        public Service ChangeWorkStatus(string e, int id)
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

        public void EditInfo(Service e)
        {
            throw new NotImplementedException();
        }

        public List<Service> Get()
        {
            throw new NotImplementedException();
        }

        public Service Get(int id)
        {
            var e = (from d in db.Services
                     where d.id == id
                     select d).FirstOrDefault();
            return e;

        }

        public Service GetCustomerInfo(int id)
        {
            throw new NotImplementedException();
        }

        public List<Service> GetDetails(int id)
        {
            throw new NotImplementedException();
        }
    }
}
