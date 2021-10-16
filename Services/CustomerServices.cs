using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JApi.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace JApi.Services
{
    public  class CustomerServices : IServices<Customer>
    {
        
        private readonly AppDbContext _appDb;
        public  CustomerServices(AppDbContext appDb)
        {   
            _appDb = appDb;
        }
        public bool Add(Customer obj)
        {
            bool status;
            try
            {
                _appDb.Customers.Add(obj);
                _appDb.SaveChanges();
                status = true;

            }
            catch(Exception)
            {
                status = false;
            }
            return status;
        }

        public bool Delete(Customer obj)
        {
             bool status;
            try
            {
                obj.IsActive =false;
                obj.IsDelete =true;
                status = Update(obj);

            }
            catch(Exception)
            {
                status = false;
            }
            return status;
        }

        public  List<Customer> Get() =>  _appDb.Customers.ToList();
        public  Customer Get(int id) =>  _appDb.Customers.FirstOrDefault(f=>f.Id==id);

        public bool Update(Customer obj)
        {
            bool status;
            try
            {
               Customer cust = _appDb.Customers.FirstOrDefault(f=>f.Id==obj.Id);
               if(cust is null)
                    return false;
                
                _appDb.Entry(cust).CurrentValues.SetValues(obj);
                _appDb.SaveChanges();
                status = true;
                
            }
            catch(Exception )
            {
                status = false;
            }
          return status;


        }





   


    }
}