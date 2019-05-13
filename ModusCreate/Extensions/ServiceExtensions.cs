using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace ModusCreate.Extensions
{
    public static class ServiceExtensions
    {

        public static void ConfigureCors(this IServiceCollection service)
        {
            service.AddCors(options => {
                options.AddPolicy("CorsPolicy", 
                    builder => builder
                        .AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader()
                        .AllowCredentials()
                );
            });
        }

        public static void ConfigureIISIntegration(this IServiceCollection service)
        {
            service.Configure<IISOptions>(options => {
                // add configure here
            });
        }


    }
}
