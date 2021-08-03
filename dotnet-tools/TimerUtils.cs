using System;
using System.Threading.Tasks;

namespace dotnet.tools
{
    public static class TimerUtils
    {
        public static async Task SetInterval(Action action, TimeSpan timeout)
        {
            action();
            await Task.Delay(timeout);
            await SetInterval(action, timeout);
        }

        public static async Task SetTimeout(Action action, TimeSpan timeout)
        {
            await Task.Delay(timeout);
            action();
        }
    }
}