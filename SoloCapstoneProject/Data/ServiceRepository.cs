using SoloCapstoneProject.Contracts;
using SoloCapstoneProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoloCapstoneProject.Data
{
    public class ServiceRepository : RepositoryBase<Service>, IServiceRepository
    {
        public ServiceRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }

        public void CreateServiceAccount(Service services) => Create(services);

        public void DeleteServiceAccount(Service services) => Delete(services);

        public Service GetServiceId(int id)
        {
            var serviceAccount = FindByCondition(s => s.ServiceId == id).SingleOrDefault();
            return serviceAccount;
        }

        public void Save()
        {
            ApplicationDbContext.SaveChanges();
        }

        public void UpdateServiceAccount(Service services) => Update(services);
    }
}
