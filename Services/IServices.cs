using System.Security.AccessControl;
using System.Collections.Generic;
using System.Linq;
using JApi.Data.Models;
using System.Threading.Tasks;

namespace JApi.Services
{
    public interface IServices<T>
    {
         
         public  List<T> Get();
         public  T Get(int id);
         public bool Add(T obj);
         public bool Delete(T obj);
         public bool Update(T obj);

    }
}