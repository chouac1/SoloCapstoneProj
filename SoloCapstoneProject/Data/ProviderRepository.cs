using SoloCapstoneProject.Contracts;
using SoloCapstoneProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoloCapstoneProject.Data
{
    public class ProviderRepository : RepositoryBase<Providers>, IProviderRepository
    {
        public ProviderRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }

        public void CreateProviderAccount(Providers providers) => Create(providers);

        public void DeleteProviderAccount(Providers providers) => Delete(providers);

        public Providers GetProviderId(int id)
        {
            var providerAccount = FindByCondition(p => p.ProviderId == id).SingleOrDefault();
            return providerAccount;
        }

        public void Save()
        {
            ApplicationDbContext.SaveChanges();
        }

        public void UpdateProviderAccount(Providers providers) => Update(providers);
    }
}
