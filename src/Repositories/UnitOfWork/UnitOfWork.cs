using Blueprints;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.UnitOfWork
{
    public sealed class UnitOfWork : IUnitOfWork
    

    {
        private readonly PaymentGateawayDBContext _context;
        public UnitOfWork(PaymentGateawayDBContext context)
        {
            _context = context;
        }
        
        //TODO: BeginTransaction
        public async Task SaveAsync() => await _context.SaveChangesAsync();
      
    }
}
