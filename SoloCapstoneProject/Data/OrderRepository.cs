using SoloCapstoneProject.Contracts;
using SoloCapstoneProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoloCapstoneProject.Data
{
    public class OrderRepository : RepositoryBase<Order>, IOrderRepository
    {
        public OrderRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }

        public void CreateOrder(Order orders) => Create(orders);

        public void DeleteOrder(Order orders) => Delete(orders);

        public Order GetOrdersId(int orderId)
        {
            var orderAccount = FindByCondition(o => o.OrderId == orderId).SingleOrDefault();
            return orderAccount;
        }

        public void Save()
        {
            ApplicationDbContext.SaveChanges();
        }

        public void UpdateOrder(Order orders) => Update(orders);
    }
}
