using SoloCapstoneProject.Contracts;
using SoloCapstoneProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoloCapstoneProject.Data
{
    public class ServiceRepository : RepositoryBase<Services>, IServiceRepository
    {
        public ServiceRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }

        public void CreateServiceAccount(Services services) => Create(services);

        public void DeleteServiceAccount(Services services) => Delete(services);

        public Services GetServiceId(int id)
        {
            var serviceAccount = FindByCondition(s => s.ServiceId == id).SingleOrDefault();
            return serviceAccount;
        }

        public void Save()
        {
            ApplicationDbContext.SaveChanges();
        }

        public void UpdateServiceAccount(Services services) => Update(services);
    }
}
