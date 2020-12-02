using System;
using System.Diagnostics;
using System.ServiceProcess;
using System.Threading;
using System.IO;
using IntegradorWebService.Visualset.IntegradorWebService;

namespace Visualset.IntegradorWebService.Service
{
    public partial class Service1 : ServiceBase
    {
        Timer timer1;

        public Service1()
        {
            InitializeComponent();
        }


        protected override void OnStart(string[] args)
        {
            //Debugger.Launch();           
            timer1 = new Timer(new TimerCallback(timer1_Tick), null, 0, 300000);
        }

        protected override void OnStop()
        {
            if (!Directory.Exists(@"C:\Visualset.IntegradorWebService"))
            {
                Directory.CreateDirectory(@"C:\Visualset.IntegradorWebService");
            }
            using (StreamWriter vWriter = new StreamWriter(@"C:\Visualset.IntegradorWebService\LogServico.txt", true))
            {
                vWriter.WriteLine("Servico Parado: " + DateTime.Now.ToString());
                vWriter.Flush();
                vWriter.Close();
            }

        }

        public void timer1_Tick(object sender)
        {
            if (!Directory.Exists(@"C:\Visualset.IntegradorWebService"))
            {
                Directory.CreateDirectory(@"C:\Visualset.IntegradorWebService");
            }

            new PostagemAutomatica();

            using (StreamWriter vWriter = new StreamWriter(@"C:\Visualset.IntegradorWebService\LogServico.txt", true))
            {
                vWriter.WriteLine("Importação concluida: " + DateTime.Now.ToString());
                vWriter.Flush();
                vWriter.Close();
            }



        }
    }
}
