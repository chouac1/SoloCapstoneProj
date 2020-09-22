using SoloCapstoneProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoloCapstoneProject.Contracts
{
    public interface IServiceRepository : IRepositoryBase<Service>
    {
        Service GetServiceId(int id);
        void CreateServiceAccount(Service services);
        void UpdateServiceAccount(Service services);
        void DeleteServiceAccount(Service services);
        void Save();
    }
}
