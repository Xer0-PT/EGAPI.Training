using Castle.Core.Logging;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace gateway
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApplication<BookStoreGatewayHostModule>();
        }

        public void Configure(IApplicationBuilder app/*, IWebHostEnvironment env, ILoggerFactory loggerFactory*/)
        {
            app.InitializeApplication();
        }
    }
}
