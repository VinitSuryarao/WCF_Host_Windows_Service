using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using CalculatorLibrary;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace WindowsServiceHost
{
    public partial class MyServiceHost : ServiceBase
    {
        private ServiceHost host = null;
        public MyServiceHost()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            host = new ServiceHost(typeof(CalculatorLibService));
            host.Open();

        }

        protected override void OnStop()
        {
            if(host != null)
            {
                host.Close();
            }
            host = null;
        }
    }
}
