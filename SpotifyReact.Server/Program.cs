using System;

namespace SpotifyReact.Server
{
    class Program
    {
        private static readonly string Url = "http://localhost:9000";
        static void Main(string[] args)
        {
            using (Microsoft.Owin.Hosting.WebApp.Start<Startup1>(Url))
            {
                System.Diagnostics.Process.Start(Url + "/index.htm");

                Console.WriteLine("Press [enter] to quit...");
                Console.ReadLine();
            }
        }
    }
}
