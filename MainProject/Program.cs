using Blueprints;
using Entities;
using Entities.Models;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Repositories;
using Repositories.UnitOfWork;
using Services;
using Services.Blueprints;
using System.Reflection;

namespace MainProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ServiceAssembly = Assembly.GetAssembly(typeof(IServiceManager));

            IHost host = Host.CreateDefaultBuilder().ConfigureServices(services =>
            {

                services.AddSingleton<IApplication, Application>();
                services.AddDbContext<PaymentGatewayDbContext>(options =>
                { options.UseSqlServer(""); });
               
             
                services.AddScoped<IClockProvider, SystemTimeProviderService>();
                services.AddScoped<IUnitOfWork, UnitOfWork>();
                services.AddScoped<IRepositoryManager, RepositoryManager>();
                services.AddScoped<IServiceManager, ServiceManager>();
             




            }).Build();

            var app = host.Services.GetRequiredService<IApplication>();
            app.Run();
        }

        
    }
}
