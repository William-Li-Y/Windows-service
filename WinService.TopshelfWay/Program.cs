using System;
using Topshelf;

namespace WinService.TopshelfWay
{
    class Program
    {
        static void Main(string[] args)
        {
            HostFactory.Run(x =>
            {
                x.Service<LoggingService>();
                x.EnableServiceRecovery(r => r.RestartService(TimeSpan.FromSeconds(10)));
                x.SetServiceName("WinServiceTopshelfWay");
                x.StartAutomatically();
            });
        }
    }
}
