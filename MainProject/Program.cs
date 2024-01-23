using Blueprints;
using Entities;
using Entities.Models;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Repositories;
using Repositories.UnitOfWork;
using Services;
using Services.Blueprints;
using Shared;
using System.Diagnostics;
using System.Reflection;
using System.Text.Json;

namespace MainProject
{
    internal class Program
    {
     
        static void Main(string[] args)
        {


            //either scan a specific directory for all .dlls


            //manually specifiy all dlls but scan assemblies within
            //var IServiceAssembly = Assembly.GetAssembly(typeof(Services.AssemblyRef));


            //var ServiceAssembly = Assembly.GetAssembly(typeof(Services.AssemblyRef));
            //ServiceAssembly.GetTypes().ToList().ForEach(t =>
            //{
            //    Console.WriteLine(t.Name);



            //});



            IHost host = Host.CreateDefaultBuilder().ConfigureServices(services =>
            {
                services.AddScoped<IApplication, Application>();
                services.AddDbContext<PaymentGatewayDbContext>(options =>
                {
                    options.UseSqlServer
                    (@"server=DESKTOP-HFUQ8MH\ALISQL2019; Initial Catalog=PaymentGateaway; Integrated Security=true; Encrypt=True; TrustServerCertificate=True");
                });

                ////@"server=DESKTOP-HFUQ8MH\ALISQL2019; database=PaymentGateaway; Integrated Security=true"

                //services.AddScoped<IClockProvider, SystemTimeProviderService>();
                //services.AddScoped<IUnitOfWork, UnitOfWork>();
                //services.AddScoped<IRepositoryManager, RepositoryManager>();
                //services.AddScoped<IServiceManager, ServiceManager>();

                services.AddServices();
             

            }).Build();

            var app = host.Services.GetRequiredService<IApplication>();
            app.Run();
        }

        
    }
}
