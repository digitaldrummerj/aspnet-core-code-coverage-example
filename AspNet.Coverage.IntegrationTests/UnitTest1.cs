using System;
using Aspnet.Coverage.Api;
using Xunit;

namespace Aspnet.Coverage.IntegrationTests
{
    public class WeatherForecastTests
    {
        [Fact]
        public void ConvertToC()
        {
            WeatherForecast wf = new WeatherForecast
            {
                TemperatureC = 14
            };

            Assert.Equal(14, wf.TemperatureC);


        }
    }
}