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
        private readonly PaymentGatewayDbContext _context;
        public UnitOfWork(PaymentGatewayDbContext context)
        {
            _context = context;
        }
        
        //TODO: BeginTransaction
        public async Task SaveAsync() => await _context.SaveChangesAsync();
      
    }
}
