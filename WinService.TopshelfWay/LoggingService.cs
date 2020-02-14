using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Topshelf;

namespace WinService.TopshelfWay
{
    public class LoggingService : ServiceControl
    {
        private const string _logFileLocation = @"C:\temp\servicelog.txt";

        private void Log(string message)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(_logFileLocation));
            File.AppendAllText(_logFileLocation, DateTime.UtcNow.ToString() + ":" + message + Environment.NewLine);
        }
        public bool Start(HostControl hostControl)
        {
            Log("Starting");
            throw new NotImplementedException();
        }

        public bool Stop(HostControl hostControl)
        {
            Log("Stopping");
            throw new NotImplementedException();
        }
    }
}
