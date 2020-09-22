using SoloCapstoneProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoloCapstoneProject.Contracts
{
    public interface IServiceRepository : IRepositoryBase<Services>
    {
        Services GetServiceId(int id);
        void CreateServiceAccount(Services services);
        void UpdateServiceAccount(Services services);
        void DeleteServiceAccount(Services services);
        void Save();
    }
}
