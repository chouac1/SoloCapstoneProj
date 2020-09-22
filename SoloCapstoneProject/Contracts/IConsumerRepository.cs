using SoloCapstoneProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoloCapstoneProject.Contracts
{
    public interface IConsumerRepository : IRepositoryBase<Consumer>
    {

        Consumer GetConsumerId(int consumerId);
        void CreateConsumerAccount(Consumer consumers);
        void UpdateConsumerAccount(Consumer consumers);
        void DeleteConsumerAccount(Consumer consumers);
        void Save();

    }
}
