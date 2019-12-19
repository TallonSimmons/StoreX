using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Reflection;

namespace Simple_Shop.Web.State
{
    public static class StoreXConfiguration
    {
        public static void AddStoreX(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());

            var storeImplementations = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .Where(x => x.IsClass && !x.IsAbstract && x.IsSubclassOf(typeof(StoreXStore)));

            foreach (var implementation in storeImplementations)
            {
                services.AddScoped(implementation);
            }
        }
    }
}
