using SoloCapstoneProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoloCapstoneProject.Contracts
{
    public interface IProviderAvailabilityRepository : IRepositoryBase<ProviderAvailability>
    {
        ProviderAvailability GetProviderAvailabilityId(int providerAvailabilityId);
        void CreateProviderAvailabilityAccount(ProviderAvailability providerAvailability);
        void UpdateProviderAvailabilityAccount(ProviderAvailability providerAvailability);
        void DeleteProviderAvailabilityAccount(ProviderAvailability providerAvailability);
        void Save();
    }
}
