using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blueprints
{
    public interface IPaymentRepository 
    {
        IEnumerable<Payment> GetAllPayments();

        void AddPayment(Payment payment);

 
    }
}
