using Marscore.Index.Core;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Marscore.Index
{
   public class MarscoreStartup
   {
      public IConfiguration Configuration { get; }

      public MarscoreStartup(IConfiguration configuration)
      {
         Configuration = configuration;
      }

      public void ConfigureServices(IServiceCollection services)
      {
         Startup.AddIndexerServices(services, Configuration);
      }

      public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
      {
         Startup.Configure(app, env);
      }
   }
}
