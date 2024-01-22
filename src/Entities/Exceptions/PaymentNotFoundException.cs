using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exceptions
{
    public sealed class PaymentNotFoundException : Exception
    {
        public PaymentNotFoundException() : base("Payment was not found")
        { }
    }
}
