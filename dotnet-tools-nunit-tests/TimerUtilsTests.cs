using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading.Tasks;

namespace dotnet.tools.nunit.tests
{
    [TestClass]
    public class TimerUtilsTests
    {
        [TestMethod]
        public async Task SetTimeoutTest()
        {
            var data = "NotSet";
            Assert.AreEqual("NotSet", data);
            TimerUtils.SetTimeout(() => data = "test", TimeSpan.FromMilliseconds(1000));
            await Task.Delay(1000);
            Assert.AreEqual("test", data);
        }
        [TestMethod]
        public async Task SetIntervalTest()
        {
            var count = 0;
            Assert.AreEqual(0, count);
            TimerUtils.SetInterval(() => count++, TimeSpan.FromMilliseconds(1000));
            await Task.Delay(1000);
            Assert.AreEqual(1, count);
        }
    }
}
