using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Infrastructure
{
    public class PaymentGatewayDbContext : DbContext
    {

        public DbSet<Payment>? Payment { get; set; }

   

        //options and builder patterns for db context
        public PaymentGatewayDbContext(DbContextOptions optionsBuilder) : base(optionsBuilder)
        {

            // optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=PaymentGateawayDb;Trusted_Connection=True;");

          
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            base.OnModelCreating(modelBuilder);
        }



    }
}
