using SoloCapstoneProject.Contracts;
using SoloCapstoneProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoloCapstoneProject.Data
{
    public class ProviderAvailabilityRepository : RepositoryBase<ProviderAvailability>, IProviderAvailabilityRepository
    {
        public ProviderAvailabilityRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }

        public void CreateProviderAvailabilityAccount(ProviderAvailability providerAvailability) => Create(providerAvailability);

        public void DeleteProviderAvailabilityAccount(ProviderAvailability providerAvailability) => Delete(providerAvailability);

        public ProviderAvailability GetProviderAvailabilityId(int providerAvailabilityId)
        {
            var providerAvailAccount = FindByCondition(p => p.ProviderAvailablityId == providerAvailabilityId).SingleOrDefault();
            return providerAvailAccount;
        }

        public void Save()
        {
            ApplicationDbContext.SaveChanges();
        }

        public void UpdateProviderAvailabilityAccount(ProviderAvailability providerAvailability)
        {
            throw new NotImplementedException();
        }
    }
}
