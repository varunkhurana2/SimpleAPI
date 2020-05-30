using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.Tests
{
    public class UnitTest1
    {
        WeatherForecastController controller=new WeatherForecastController();
        [Fact]
        public void GetReturnMyName()
        {
            var returnValue=controller.Get();
            Assert.Equal(returnValue.ToString().Length>0,true);
        }
        [Fact]
        public void Test1()
        {

        }
    }
}
