using SoloCapstoneProject.Contracts;
using SoloCapstoneProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoloCapstoneProject.Data
{
    public class ConsumerRepository : RepositoryBase<Consumer>, IConsumerRepository
    {
        public ConsumerRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }

        public void CreateConsumerAccount(Consumer consumers) => Create(consumers);

        public void DeleteConsumerAccount(Consumer consumers) => Delete(consumers);
        public Consumer GetConsumerId(int consumerId)
        {
            var consumerAccount = FindByCondition(c => c.ConsumerId.Equals(consumerId)).SingleOrDefault();
            return consumerAccount;
        }

        public void Save()
        {
            ApplicationDbContext.SaveChanges();
        }

        public void UpdateConsumerAccount(Consumer consumers) => Update(consumers);
    }
}
