using System.ServiceProcess;
using Serilog;

namespace WindowsService
{
    public partial class Service : ServiceBase
    {
        public Service()
        {
            InitializeComponent();
        }

        public void ConsoleStart(string[] args)
        {
            OnStart(args);
        }

        public void ConsoleStop()
        {
            OnStop();
        }

        protected override void OnStart(string[] args)
        {
            Log.Information("Starting up...");
        }

        protected override void OnStop()
        {
            Log.Information("Shutting down...");
        }
    }
}
