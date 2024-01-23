using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blueprints;
using Infrastructure;
using Repositories.UnitOfWork;

namespace Repositories
{
    public sealed class RepositoryManager : IRepositoryManager
    {
        private readonly PaymentGatewayDbContext _paymentGatewayDbContext;
        private readonly Lazy<IPaymentRepository> _paymentRepository;
  

        public RepositoryManager(PaymentGatewayDbContext paymentGatewayDbContext)
        {

            //init as lazy to create only 1 instance on the thread, and create only once
            //can be made to be used by multiple threads at the time

            _paymentGatewayDbContext = paymentGatewayDbContext;
            _paymentRepository = new Lazy<IPaymentRepository>(
                () => new PaymentRepository(paymentGatewayDbContext));

           
         
        }


        public IPaymentRepository PaymentRepository => _paymentRepository.Value;



        



    }
}
