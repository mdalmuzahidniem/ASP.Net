using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EmployeeRepo:IRepository<User,int,string>,IAuth
    {
        Service_Entities db;
        public EmployeeRepo(Service_Entities db)
        {
            this.db = db;
        }

        public void Add(User e)
        {
            throw new NotImplementedException();
        }
        public User ChangeWorkStatus(string e, int id)
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

        public void EditInfo(User s)
        {
            var entity = (from emp in db.Users
                          where emp.id == s.id
                          select emp).FirstOrDefault();
            entity.name = s.name.Trim();
            entity.phone = s.phone.Trim();
            entity.email = s.email.Trim();
            entity.password = s.password.Trim();
            entity.house = s.house.Trim();
            entity.road = s.road.Trim();
            db.SaveChanges();
        }

        public List<User> Get()
        {
            throw new NotImplementedException();
        }

        public User Get(int id)
        {
            return db.Users.FirstOrDefault(e => e.id == id);
        }

        public User GetCustomerInfo(int id)
        {
            throw new NotImplementedException();
        }

        public List<User> GetDetails(int id)
        {
            throw new NotImplementedException();
        }
        public Token Authenticate(User user)
        {
            var u = db.Users.FirstOrDefault(en => en.name.Equals(user.name) && en.password.Equals(user.password));
            Token t = null;
            if (u != null)
            {
                string token = Guid.NewGuid().ToString();
                t = new Token();
                t.userId = u.id;
                t.accessToken = token;
                t.createdAt = DateTime.Now;
                db.Tokens.Add(t);
                db.SaveChanges();
            }
            return t;
        }

        public bool IsAuthenticated(string token)
        {
            var rs = db.Tokens.Any(e => e.accessToken.Equals(token) && e.expiredAt == null);
            return rs;
        }

        public bool logout(string token)
        {
            var t = db.Tokens.FirstOrDefault(e => e.accessToken.Equals(token));
            if (t != null)
            {
                t.expiredAt = DateTime.Now;
                db.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
