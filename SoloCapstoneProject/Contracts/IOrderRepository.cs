using SoloCapstoneProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoloCapstoneProject.Contracts
{
    public interface IOrderRepository : IRepositoryBase<Order>
    {

        Order GetOrdersId(int orderId);
        void CreateOrder(Order orders);
        void UpdateOrder(Order orders);
        void DeleteOrder(Order orders);
        void Save();

    }
}
