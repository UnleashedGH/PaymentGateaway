using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Blueprints
{
    public interface IPaymentService
    {

        IEnumerable<Payment> GetPayments();

        Task IssuePayment(Payment payment);

        string ReturnHello();
    }
}
