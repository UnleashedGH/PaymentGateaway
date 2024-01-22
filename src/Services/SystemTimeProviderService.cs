using Blueprints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class SystemTimeProviderService : IClockProvider
    {
        public DateTime CurrentDateTime()
        {
          return DateTime.Now;
        }
    }
}
