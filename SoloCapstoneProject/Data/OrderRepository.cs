using SoloCapstoneProject.Contracts;
using SoloCapstoneProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoloCapstoneProject.Data
{
    public class OrderRepository : RepositoryBase<Orders>, IOrderRepository
    {
        public OrderRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }

        public void CreateOrder(Orders orders) => Create(orders);

        public void DeleteOrder(Orders orders) => Delete(orders);

        public Orders GetOrdersId(int orderId)
        {
            var orderAccount = FindByCondition(o => o.OrderId == orderId).SingleOrDefault();
            return orderAccount;
        }

        public void Save()
        {
            ApplicationDbContext.SaveChanges();
        }

        public void UpdateOrder(Orders orders) => Update(orders);
    }
}
