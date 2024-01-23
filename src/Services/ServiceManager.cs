using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blueprints;
using Infrastructure;
using Services.Blueprints;
using Shared;

namespace Services
{
    public sealed class ServiceManager : IServiceManager, IInjectable
    {
        private readonly Lazy<IPaymentService> _paymentService;

        public ServiceManager(IRepositoryManager repositoryManager, IUnitOfWork unitOfWork)
        {


            _paymentService = new Lazy<IPaymentService>(
                () => new PaymentService(repositoryManager, unitOfWork));

            
        }
        public IPaymentService PaymentService => _paymentService.Value;
     
    }
}
