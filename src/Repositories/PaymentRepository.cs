using Blueprints;
using Entities.Models;
using Infrastructure;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public sealed class PaymentRepository : BaseRepository<Payment>, IPaymentRepository
    {

        public PaymentRepository(PaymentGateawayDBContext paymentGateawayDBContext) : 
            base(paymentGateawayDBContext)
        {
         
           
        }

        public IEnumerable<Payment> GetAllPayments() =>
            GetAll()
           .OrderBy(p => p.Id)
           .ToList();




        public void AddPayment(Payment payment) => Create(payment);

      
    }
}
