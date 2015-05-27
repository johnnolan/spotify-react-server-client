using System;
using Microsoft.Owin;
using Owin;
using System.IO;
using Microsoft.Owin.FileSystems;
using Microsoft.Owin.StaticFiles;
using System.Web.Http;
using SpotifyReact.Server;

[assembly: OwinStartup(typeof(Startup1))]

namespace SpotifyReact.Server
{
    public class Startup1
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseErrorPage();
            string root = AppDomain.CurrentDomain.BaseDirectory;

            app.UseFileServer(new FileServerOptions
            {
                FileSystem = new PhysicalFileSystem(Path.Combine(root, "web")),
                RequestPath = new PathString(),
                EnableDirectoryBrowsing = true
            });

            HttpConfiguration config = new HttpConfiguration();
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            app.UseWebApi(config);
        }
    }
}