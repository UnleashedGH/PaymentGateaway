using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Blueprints
{
    public interface IServiceManager
    {

        IPaymentService PaymentService { get; }
    }
}
