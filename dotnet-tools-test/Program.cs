using System;
using System.Threading.Tasks;

namespace dotnet.tools.test
{
    class Program
    {
        static async Task Main(string[] args)
        {
            while (true)
            {
                Task.Run(() => TimerUtils.SetInterval(() => Console.WriteLine("SetInterval test - Hello World!"), TimeSpan.FromMilliseconds(1000)));
                Task.Run(() => TimerUtils.SetTimeout(() => Console.WriteLine("SetTimeout test - Hello World!"), TimeSpan.FromMilliseconds(1000)));
            }
        }
    }
}
