using System;
using System.IO;
using System.ServiceProcess;
using Serilog;

namespace WindowsService
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            Directory.SetCurrentDirectory(AppDomain.CurrentDomain.BaseDirectory);

            Log.Logger = new LoggerConfiguration()
             .ReadFrom.AppSettings()
             .CreateLogger();

            var service = new Service();

            if (Environment.UserInteractive)
            {
                service.ConsoleStart(args);
                Console.WriteLine("Press any key to stop program");
                Console.Read();
                service.ConsoleStop();
            }
            else
            {
                ServiceBase.Run(service);
            }
        }
    }
}
