using SoloCapstoneProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoloCapstoneProject.Contracts
{
    public interface IOrderRepository : IRepositoryBase<Orders>
    {

        Orders GetOrdersId(int orderId);
        void CreateOrder(Orders orders);
        void UpdateOrder(Orders orders);
        void DeleteOrder(Orders orders);
        void Save();

    }
}
