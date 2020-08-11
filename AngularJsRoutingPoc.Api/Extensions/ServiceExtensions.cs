using AngularJsRoutingPoc.ApiModules.Grocery;
using Microsoft.Extensions.DependencyInjection;
using AngularJsRoutingPoc.Business.Interfaces;
using AngularJsRoutingPoc.Business.Grocery;
using AngularJsRoutingPoc.DataAccess.Interfaces;
using AngularJsRoutingPoc.DataAccess.Grocery;
using System.Text.Json;

namespace AngularJsRoutingPoc.Api.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureServiceModules(this IServiceCollection services)
        {
            services.AddControllers()
                .AddJsonOptions(options =>
                {
                    options.JsonSerializerOptions.IgnoreNullValues = true;
                    options.JsonSerializerOptions.PropertyNameCaseInsensitive = true;
                })
                .AddApplicationPart(typeof(GroceryController).Assembly);
        }

        public static void ConfigureProjectDependencies(this IServiceCollection services)
        {
            services.AddTransient<IGroceryManager, GroceryManager>();
            services.AddTransient<IGroceryRepository, GroceryRepository>();
        }
    }
}
