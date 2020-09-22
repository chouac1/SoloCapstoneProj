using SoloCapstoneProject.Contracts;
using SoloCapstoneProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoloCapstoneProject.Data
{
    public class ConsumerRepository : RepositoryBase<Consumers>, IConsumerRepository
    {
        public ConsumerRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }

        public void CreateConsumerAccount(Consumers consumers) => Create(consumers);

        public void DeleteConsumerAccount(Consumers consumers) => Delete(consumers);
        public Consumers GetConsumerId(int consumerId)
        {
            var consumerAccount = FindByCondition(c => c.ConsumerId.Equals(consumerId)).SingleOrDefault();
            return consumerAccount;
        }

        public void Save()
        {
            ApplicationDbContext.SaveChanges();
        }

        public void UpdateConsumerAccount(Consumers consumers) => Update(consumers);
    }
}
