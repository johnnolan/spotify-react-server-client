using System;
using Microsoft.Owin;
using Owin;
using SpotifyReact.Api;
using System.IO;
using Microsoft.Owin.FileSystems;
using Microsoft.Owin.StaticFiles;

[assembly: OwinStartup(typeof(Startup1))]

namespace SpotifyReact.Api
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
        }
    }
}