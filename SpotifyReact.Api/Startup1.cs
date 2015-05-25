using System;
using Microsoft.Owin;
using Owin;
using SpotifyReact.Api;

[assembly: OwinStartup(typeof(Startup1))]

namespace SpotifyReact.Api
{
    public class Startup1
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseErrorPage();

            app.Run(context =>
            {
                if (context.Request.Path.ToString() == "/fail")
                {
                    throw new Exception("Random exception");
                }

                context.Response.ContentType = "text/plain";
                return context.Response.WriteAsync("Hello, world.");
            });
        }
    }
}