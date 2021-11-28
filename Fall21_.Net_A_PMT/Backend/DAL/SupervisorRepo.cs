using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SupervisorRepo
    {
        static assignmentEntities db;
        
        static SupervisorRepo()
        {
            db = new assignmentEntities();
        }
        public static List<Project> Get()
        {
            return db.Projects.ToList();
        }
        public static List<Project> Get(string status)
        {
            var data = (from p in db.Projects where p.status == status select p).ToList();
            return data;
        }
        public static List<AssignedProject> GetRequest(string status)
        {
            var data = (from p in db.AssignedProjects where p.status == status select p).ToList();
            return data;
        }
        public static void edit(Project s)
        {
            var ds = db.Projects.FirstOrDefault(e => e.id == s.id);
            db.Entry(ds).CurrentValues.SetValues(s);
            db.SaveChanges();
        }
        public static void Add(Project s)
        {
            db.Projects.Add(s);
            db.SaveChanges();
        }
        
    }

}
