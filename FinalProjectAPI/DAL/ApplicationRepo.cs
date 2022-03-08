using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ApplicationRepo : IRepository<Application, int, string>
    {
        Service_Entities db;
        public ApplicationRepo(Service_Entities db)
        {
            this.db = db;
        }
        public void Add(Application e)
        {
            Application a = new Application();

            a.start_date = e.start_date;
            a.end_date = e.end_date;
            a.application_subject = e.application_subject.Trim();
            a.application_status = "process";
            a.employee_id = e.employee_id;

            db.Applications.Add(a);
            db.SaveChanges();
        }

        public Application ChangeWorkStatus(string e, int id)
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

        public void EditInfo(Application e)
        {
            throw new NotImplementedException();
        }

        public List<Application> Get()
        {
            throw new NotImplementedException();
        }

        public Application Get(int id)
        {
            throw new NotImplementedException();
        }

        public Application GetCustomerInfo(int id)
        {
            throw new NotImplementedException();
        }

        public List<Application> GetDetails(int id)
        {
            var e = (from h in db.Applications
                     where h.employee_id == id && h.application_status == "process"
                     select h).ToList();
            return e;
        }
    }
}
