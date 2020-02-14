using System;
using System.ServiceProcess;

namespace WinService.MicrosoftWay
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceBase.Run(new LoggingService());
            Console.WriteLine("Hello World!");
        }
    }
}
