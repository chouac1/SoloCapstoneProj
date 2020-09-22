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
        private IConsumersRepository _consumers;
        private IOrderRepository _orders;
        private IProviderAvailabilityRepository _providerAvailability;
        private IProvidersRepository _providers;
        private IServicesRepository _services;

        public RepositoryWrapper(ApplicationDbContext context)
        {
            _context = context;
        }

        public IConsumersRepository Consumers
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

        public IProviderAvailabilityRepository ProviderAvailability
        {
            get
            {
                if (_providerAvailability == null)
                {
                    _providerAvailability = new ProviderAvailabilityRepository(_context);
                }
                return _providerAvailability;
            }
        }

        public IProvidersRepository Providers
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

        public IServicesRepository Services
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
