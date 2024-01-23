using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    //POCO
    public class Payment : BaseEntity
    {
        public long PaymentNumber { get; set; }
        public DateTime PaymentDate { get; set; }
    }
}
