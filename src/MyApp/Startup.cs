using System;
using System.Configuration;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Funq;
using ServiceStack;
using MyApp.ServiceInterface;
using MyApp.ServiceInterface.Business;
using ServiceStack.Api.Swagger;
using ServiceStack.Data;
using ServiceStack.OrmLite;

namespace MyApp
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration) => Configuration = configuration;

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {

        }
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseServiceStack(new AppHost
            {
                AppSettings = new NetCoreAppSettings(Configuration)
            });
        }
    }

    public class AppHost : AppHostBase
    {
        public AppHost() : base("MyApp", typeof(MyServices).Assembly) { }

        // Configure your AppHost with the necessary configuration and dependencies your App needs
        public override void Configure(Container container)
        {
            container.RegisterAutoWiredAs<AdrBusiness, IAdrBusiness>().ReusedWithin(ReuseScope.None);
            Plugins.Add(new SwaggerFeature());
            //LogManager.LogFactory = new Log4NetFactory(configureLog4Net: true);
            String strMedsci = AppSettings.Get<String>("ConnStr.PV_DB");
            container.Register<IDbConnectionFactory>(new OrmLiteConnectionFactory(strMedsci, MySqlDialect.Provider));
            SetConfig(new HostConfig
            {
                DefaultRedirectPath = "/metadata",
                DebugMode = AppSettings.Get(nameof(HostConfig.DebugMode), false)
            });
        }
    }
}
