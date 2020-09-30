using SoloCapstoneProject.Contracts;
using SoloCapstoneProject.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoloCapstoneProject
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private ApplicationDbContext _context;
        private IConsumerRepository _consumers;
        private IOrderRepository _orders;
        private IProviderScheduleRepository _providerAvailability;
        private IProviderRepository _providers;
        private IServiceRepository _services;

        public RepositoryWrapper(ApplicationDbContext context)
        {
            _context = context;
        }

        public IConsumerRepository Consumers
        {
            get
            {
                if (_consumers == null)
                {
                    _consumers = new ConsumerRepository(_context);
                }
                return _consumers;
            }
        }

        public IOrderRepository Order
        {
            get
            {
                if (_orders == null)
                {
                    _orders = new OrderRepository(_context);
                }
                return _orders;
            }
        }

        public IProviderScheduleRepository ProviderAvailability
        {
            get
            {
                if (_providerAvailability == null)
                {
                    _providerAvailability = new ProviderScheduleRepository(_context);
                }
                return _providerAvailability;
            }
        }

        public IProviderRepository Providers
        {
            get
            {
                if (_providers == null)
                {
                    _providers = new ProviderRepository(_context);
                }
                return _providers;
            }
        }

        public IServiceRepository Services
        {
            get
            {
                if (_services == null)
                {
                    _services = new ServiceRepository(_context);
                }
                return _services;
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
