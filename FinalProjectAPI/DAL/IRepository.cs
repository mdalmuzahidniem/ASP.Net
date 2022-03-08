using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IRepository<T,ID,S>
    {
        void Add(T e);
        void Edit(ID id);

        T ChangeWorkStatus(S e, ID id);
        void EditInfo(T e);
        void Delete(ID id);
        List<T> Get();
        List<T> GetDetails(ID id);
        T Get(ID id);
        T GetCustomerInfo(ID id);
    }
}
