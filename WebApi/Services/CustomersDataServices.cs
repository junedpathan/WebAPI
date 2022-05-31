using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Services
{
    public class CustomersDataServices : IDataService<Customer, int>
    {
        private readonly ShopContext context;

        public CustomersDataServices(ShopContext ctx)
        {
            context = ctx;
        }
        public Customer Create(Customer entity)
        {
            context.Customers.Add(entity);
            context.SaveChanges();
            return entity;
        }

        public Customer Delete(int id)
        {
            var custToDelete = context.Customers.Find(id);
            if (custToDelete == null) return null;

            context.Customers.Remove(custToDelete);
            context.SaveChanges();
            return custToDelete;
        }

        public IEnumerable<Customer> Get()
        {
            return context.Customers.ToList();
        }

        public Customer Get(int id)
        {
            var custToFind = context.Customers.Find(id);
            return custToFind;
        }

        public Customer Update(int id, Customer entity)
        {
            var custToUpdate = context.Customers.Find(id);
            if (custToUpdate == null) return null;

            custToUpdate.CustName = entity.CustName;
            custToUpdate.CustEmail = entity.CustEmail;
            custToUpdate.CustAdd = entity.CustAdd;
            custToUpdate.CustCity = entity.CustCity;
            custToUpdate.CustState = entity.CustState;
            context.SaveChanges();
            return custToUpdate;
        }
    }

   
}
