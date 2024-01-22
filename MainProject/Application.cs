using Services;
using Services.Blueprints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProject
{
    internal class Application : IApplication
    {

        private readonly IServiceManager _serviceManager;

        public Application(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }
        public void Run()
        {
          Console.WriteLine(  _serviceManager.PaymentService.ReturnHello());
           // Console.Write("hello");
        }
    }
}
