using Microsoft.Owin.Hosting;
using Sample.Fpp.Business.Managers;
using Sample.Fpp.Entities;
using Sample.Fpp.Infrastructure.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Fpp.Api
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("started the app");

            string baseAddress = AppConfigUtility.AppSettingValue("baseAddress", "http://localhost:8080");

            // Start OWIN host 
            WebApp.Start<Startup>(baseAddress);
            Console.WriteLine("Server running at {0} - press Enter to quit. ", baseAddress);
            Console.ReadLine();
        }
    }
}
