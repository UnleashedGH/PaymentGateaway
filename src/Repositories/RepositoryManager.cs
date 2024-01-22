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
        private readonly PaymentGateawayDBContext _paymentGateawayDBContext;
        private readonly Lazy<IPaymentRepository> _paymentRepository;
  

        public RepositoryManager(PaymentGateawayDBContext paymentGateawayDBContext)
        {

            //init as lazy to create only 1 instance on the thread, and create only once
            //can be made to be used by multiple threads at the time

            _paymentGateawayDBContext = paymentGateawayDBContext;
            _paymentRepository = new Lazy<IPaymentRepository>(
                () => new PaymentRepository(paymentGateawayDBContext));

           
         
        }


        public IPaymentRepository PaymentRepository => _paymentRepository.Value;



        



    }
}
