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
            WeatherForecast wf = new WeatherForecast
            {
                Date = DateTime.Now,
                Summary = "Sunny",
                TemperatureC = 14
            };

            const int expectedTemperatureF = 57;

            Assert.Equal(expectedTemperatureF, wf.TemperatureF);


        }
    }
}
