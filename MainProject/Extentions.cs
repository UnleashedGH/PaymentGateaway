using Microsoft.Extensions.DependencyInjection;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MainProject
{
    public static class Extentions
    {
        public static bool ImplementsInterface(this Type type, Type ifaceType)
        {
            Type[] intf = type.GetInterfaces();
            for (int i = 0; i < intf.Length; i++)
            {
                if (intf[i] == ifaceType)
                {
                    return true;
                }
            }
            return false;
        }


        public static void AddServices(this IServiceCollection services)
        {

            var Assembilies = AppDomain.CurrentDomain.GetAssemblies();


            //var interfaces = Assembilies.Where(ass2 => ass2.FullName.Contains("Blueprints")).SelectMany(ass => ass.GetTypes())
            //    .Where(t => t.IsInterface && t.Name.StartsWith("I"));


            // Get all types in the current assembly that implement IMyService
            var AppInterfaces = Assembly.GetAssembly(typeof(Blueprints.AssemblyRef))
                                       .GetTypes()
                                       .Where(t => t.IsInterface && t.Name.StartsWith("I"));

            var ServiceInterfaces = Assembly.GetAssembly(typeof(Services.Blueprints.AssemblyRef))
                                       .GetTypes()
                                       .Where(t => t.IsInterface && t.Name.StartsWith("I"));


            var allInterfaces = AppInterfaces.Concat(ServiceInterfaces);

            //var ServicesAssembly = Assembly.GetAssembly(typeof(Services.AssemblyRef)).
            //                            GetTypes().
            //                            Where(t => !t.IsInterface);




            foreach (var serviceinterface in AppInterfaces)
            {
                var ServicesAssembly = Assembly.GetAssembly(typeof(Repositories.AssemblyRef)).
                                       GetTypes().
                                       Where(t => !t.IsInterface && !t.IsAbstract && serviceinterface.IsAssignableFrom(t))
                                      .FirstOrDefault();

                if (ServicesAssembly != null)
                    services.AddScoped(serviceinterface, ServicesAssembly);
            }

            // Register each type as a singleton service
            foreach (var serviceinterface in ServiceInterfaces)
            {
                 var ServicesAssembly = Assembly.GetAssembly(typeof(Services.AssemblyRef)).
                                        GetTypes().
                                        Where(t => !t.IsInterface && !t.IsAbstract && serviceinterface.IsAssignableFrom(t))
                                       .FirstOrDefault();

                if (ServicesAssembly != null)
                    services.AddScoped(serviceinterface, ServicesAssembly);
            }


       
           



            //for (int i = 0;i < ServiceInterfaces.Count();i++)
            //{
            //    //services.AddScoped(serviceType);
            //}
        }
    }
}
