using SoloCapstoneProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoloCapstoneProject.Contracts
{
    public interface IProviderScheduleRepository : IRepositoryBase<ProviderSchedule>
    {
        ProviderSchedule GetProviderScheduleId(int providerScheduleId);
        void CreateProviderScheduleAccount(ProviderSchedule providerSchedule);
        void UpdateProviderScheduleAccount(ProviderSchedule providerSchedule);
        void DeleteProviderScheduleAccount(ProviderSchedule providerSchedule);
        void Save();
    }
}
