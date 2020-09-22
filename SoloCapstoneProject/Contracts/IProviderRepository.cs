using SoloCapstoneProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoloCapstoneProject.Contracts
{
    public interface IProviderRepository : IRepositoryBase<Provider>
    {
        Provider GetProviderId(int id);
        void CreateProviderAccount(Provider providers);
        void UpdateProviderAccount(Provider providers);
        void DeleteProviderAccount(Provider providers);
        void Save();
    }
}
