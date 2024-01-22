﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blueprints
{
    public interface IRepositoryManager
    {
        public IPaymentRepository PaymentRepository { get; }
    }
}
