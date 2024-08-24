using XOuranos.Index.Core;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace XOuranos.Index
{
   public class XOuranosStartup
   {
      public IConfiguration Configuration { get; }

      public XOuranosStartup(IConfiguration configuration)
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
