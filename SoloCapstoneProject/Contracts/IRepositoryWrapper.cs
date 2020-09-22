using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoloCapstoneProject.Contracts
{
    public interface IRepositoryWrapper
    {
        //ICarRepository Car { get; } (SAMPLE)
        IConsumerRepository Consumers { get; }
        IOrderRepository Order { get; }
        IProviderAvailabilityRepository ProviderAvailability { get; }
        IProviderRepository Providers { get; }
        IServiceRepository Services { get; }
        void Save();
    }

}
