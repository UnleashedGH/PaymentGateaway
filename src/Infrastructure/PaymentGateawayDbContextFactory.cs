using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
  
    public class PaymentGateawayDbContextFactory : IDesignTimeDbContextFactory<PaymentGatewayDbContext>
    {
        public PaymentGatewayDbContext CreateDbContext(string[] args)
        {
            //var configuration = new ConfigurationBuilder()
            //.SetBasePath(Directory.GetCurrentDirectory())
            //.AddJsonFile("appsettings.json")
            //.Build();

            var builder = new DbContextOptionsBuilder<PaymentGatewayDbContext>()
            .UseSqlServer("Data Source=DESKTOP-HFUQ8MH\\ALISQL2019;Database=PaymentGateaway;Integrated Security=True");
            return new PaymentGatewayDbContext(builder.Options);
        }
    }
}
