using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Diagnostics;
using Microsoft.AspNet.Routing;
using Microsoft.Framework.DependencyInjection;

namespace Diagnostics.StatusCodes.Mvc
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.UseStatusCodePages(new StatusCodePagesOptions().WithReExecute("/errors/{0}"));

            // Set up application services
            app.UseServices(services =>
            {
                // Add MVC services to the services container
                services.AddMvc();
            });

            // Add MVC to the request pipeline
            app.UseMvc(routes =>
            {
                routes.MapRoute("ActionAsMethod", "{controller}/{action}",
                    defaults: new { controller = "Home", action = "Index" });
            });
        }
    }
}
