using SoloCapstoneProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoloCapstoneProject.Contracts
{
    public interface IProviderRepository : IRepositoryBase<Providers>
    {
        Providers GetProviderId(int id);
        void CreateProviderAccount(Providers providers);
        void UpdateProviderAccount(Providers providers);
        void DeleteProviderAccount(Providers providers);
        void Save();
    }
}
