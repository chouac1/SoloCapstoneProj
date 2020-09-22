using SoloCapstoneProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoloCapstoneProject.Contracts
{
    public interface IConsumerRepository : IRepositoryBase<Consumers>
    {

        Consumers GetConsumerId(int consumerId);
        void CreateConsumerAccount(Consumers consumers);
        void UpdateConsumerAccount(Consumers consumers);
        void DeleteConsumerAccount(Consumers consumers);
        void Save();

    }
}
