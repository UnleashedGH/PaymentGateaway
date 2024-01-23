using Blueprints;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class SystemTimeProviderService : IClockProvider, IInjectable
    {
        public DateTime CurrentDateTime()
        {
          return DateTime.Now;
        }
    }
}
