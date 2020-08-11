using AngularJsRoutingPoc.Business.Grocery;
using AngularJsRoutingPoc.Business.Interfaces;
using AngularJsRoutingPoc.DataAccess.Grocery;
using AngularJsRoutingPoc.DataAccess.Interfaces;
using AngularJsRoutingPoc.Web.Grocery;
using Microsoft.Extensions.DependencyInjection;

namespace AngularJsRoutingPoc.Web.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureWebModules(this IServiceCollection services)
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
