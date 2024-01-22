using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Infrastructure
{
    public class PaymentGateawayDBContext : DbContext
    {

        public DbSet<Payment> Payment { get; set; }

   

        //options and builder patterns for db context
        public PaymentGateawayDBContext(DbContextOptions optionsBuilder) : base(optionsBuilder)
        {
           // optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=PaymentGateawayDb;Trusted_Connection=True;");
        }

      

    }
}
