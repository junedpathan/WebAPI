using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Services
{
    public class OrdersDataServices : IDataService<Order, int>
    {
        private readonly ShopContext context;

        public OrdersDataServices(ShopContext ctx)
        {
            context = ctx;
        }
        public Order Create(Order entity)
        {
            context.Orders.Add(entity);
            context.SaveChanges();
            return entity;
        }

        public Order Delete(int id)
        {
            var ordToDelete = context.Orders.Find(id);
            if (ordToDelete == null) return null;

            context.Orders.Remove(ordToDelete);
            context.SaveChanges();
            return ordToDelete;
        }

        public IEnumerable<Order> Get()
        {
            return context.Orders.ToList();
        }

        public Order Get(int id)
        {
            var ordToFind = context.Orders.Find(id);
            return ordToFind;
        }

        public Order Update(int id, Order entity)
        {
            var ordToUpdate = context.Orders.Find(id);
            if (ordToUpdate == null) return null;

            ordToUpdate.OrderedItem = entity.OrderedItem;
            ordToUpdate.OrderedDate = entity.OrderedDate;
            ordToUpdate.OrderQuantity = entity.OrderQuantity;
            context.SaveChanges();
            return ordToUpdate;
        }
    }
}
