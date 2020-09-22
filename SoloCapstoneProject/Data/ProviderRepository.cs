using SoloCapstoneProject.Contracts;
using SoloCapstoneProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoloCapstoneProject.Data
{
    public class ProviderRepository : RepositoryBase<Provider>, IProviderRepository
    {
        public ProviderRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }

        public void CreateProviderAccount(Provider providers) => Create(providers);

        public void DeleteProviderAccount(Provider providers) => Delete(providers);

        public Provider GetProviderId(int id)
        {
            var providerAccount = FindByCondition(p => p.ProviderId == id).SingleOrDefault();
            return providerAccount;
        }

        public void Save()
        {
            ApplicationDbContext.SaveChanges();
        }

        public void UpdateProviderAccount(Provider providers) => Update(providers);
    }
}
