using SoloCapstoneProject.Contracts;
using SoloCapstoneProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoloCapstoneProject.Data
{
    public class ProviderScheduleRepository : RepositoryBase<ProviderSchedule>, IProviderScheduleRepository
    {
        public ProviderScheduleRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }

        public void CreateProviderScheduleAccount(ProviderSchedule providerSchedule) => Create(providerSchedule);

        public void DeleteProviderScheduleAccount(ProviderSchedule providerSchedule) => Delete(providerSchedule);

        public ProviderSchedule GetProviderScheduleId(int providerScheduleId)
        {
            var providerScheduleAccount = FindByCondition(p => p.ProviderScheduleId == providerScheduleId).SingleOrDefault();
            return providerScheduleAccount;
        }

        public void Save()
        {
            ApplicationDbContext.SaveChanges();
        }

        public void UpdateProviderScheduleAccount(ProviderSchedule providerSchedule)
        {
            throw new NotImplementedException();
        }
    }
}
