using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace Czat.HostWS
{
    public partial class CzatWS : ServiceBase
    {
        ServiceHost host;
        public CzatWS()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            RunHost();
        }

        private void RunHost()
        {
            host = new ServiceHost(typeof(Czat.Contract.CzatService));
            host.Open();
        }

        protected override void OnStop()
        {
            if (host != null)
            {
                host.Close();
                host = null;
            }
        }
    }
}
