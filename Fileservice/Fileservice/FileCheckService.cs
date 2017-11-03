using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace Fileservice
{
    public partial class FileCheckService : ServiceBase
    {
        FileLogic.Main minFilFixare;

        public FileCheckService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            minFilFixare = new FileLogic.Main() ;
            minFilFixare.Start();
        }

        protected override void OnStop()
        {
            minFilFixare.Stop();
        }
    }
}
