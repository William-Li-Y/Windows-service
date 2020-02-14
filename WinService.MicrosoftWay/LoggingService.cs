using System;
using System.Collections.Generic;
using System.IO;
using System.ServiceProcess;
using System.Text;

namespace WinService.MicrosoftWay
{
    class LoggingService : ServiceBase
    {
        private const string _logFileLocation = @"C:\temp\servicelog.txt";


        private void Log(string message)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(_logFileLocation));
            File.AppendAllText(_logFileLocation, DateTime.UtcNow.ToString()+":"+message+Environment.NewLine);
        }

        protected override void OnStart(string[] args)
        {
            Log("Starting");
            base.OnStart(args);
        }

        protected override void OnStop()
        {
            Log("Ending");
            base.OnStop();
        }

        protected override void OnPause()
        {
            Log("Pausing");
            base.OnPause();
        }
    }
}
