using System;
using Aspnet.Coverage.Api;
using Xunit;

namespace Aspnet.Coverage.UnitTests
{
    public class WeatherForecastTests
    {
        [Fact]
        public void ConvertToC()
        {
            WeatherForecast wf = new WeatherForecast();
            wf.Date = DateTime.Now;
            wf.Summary = "Sunny";
            wf.TemperatureC = 14;

            int expectedTemperatureF = 57;

            Assert.Equal(expectedTemperatureF, wf.TemperatureF);


        }
    }
}
