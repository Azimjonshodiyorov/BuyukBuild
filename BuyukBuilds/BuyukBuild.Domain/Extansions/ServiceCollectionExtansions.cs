using BuyukBuild.Domain.Attributes.Common;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BuyukBuild.Domain.Extansions
{
    public static class ServiceCollectionExtansions
    {
        public static void ConfigureRepositoriesByAssembly(this IServiceCollection collection, Assembly assembly)
        {
            var repositories = assembly.GetTypes()
                .Where(x => x.GetCustomAttribute<IsRepositoryAttribute>() is not null && x.IsClass && 
                x.GetInterfaces().Length != 0);

            foreach (var repository in repositories)
            {
                collection.AddScoped(repository.GetInterfaces().FirstOrDefault(x => 
                x.Name.EndsWith(repository.Name)!, repository));
            }
        }

        public static void ConfigureServicesByAssembly(this IServiceCollection collection, Assembly assembly)
        {
            var services = assembly.GetTypes()
                .Where(x=>x.GetCustomAttribute<IsServiceAttribute>() is not null && x.IsClass && x.GetInterfaces().Length != 0);

            foreach (var service in services)
            {
                collection.AddScoped(service.GetInterfaces().FirstOrDefault(x => x.Name.EndsWith(service.Name), service));
            }
        }
    }
}
