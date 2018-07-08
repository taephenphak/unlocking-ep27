using System;
using FluentAssertions;
using FluentAssertions.Collections;
using Moq;
using Xunit;

namespace temperature.test
{
    public class UnitTest1
    {
        [Theory(DisplayName = "เปลี่ยนค่า องศา Fahrenheit ให้เป็น Celsius ได้สำเร็จ")]
        [InlineData(32, 0)]
        [InlineData(59, 15)]
        public void ConvertFahrenheitToCelsiusSuccess(double input, double expectedResult)
        {
            var cal = new TempCalculator();
            var x = cal.ConvertFahrenheitToCelsius(input);

            x.Should().Be(expectedResult);
        }

        [Theory(DisplayName = "เปลี่ยนค่า องศา Kelvin ให้เป็น Celsius ได้สำเร็จ")]
        [InlineData(363.15, 90)]
        [InlineData(955.15, 682)]
        public void ConvertKelvinToCelsiusSuccess(double input, double expectedResult)
        {
            var cal = new TempCalculator();
            var x = cal.ConvertKelvinToCelsius(input);

            x.Should().Be(expectedResult);
        }

        [Theory(DisplayName = "เปลี่ยนค่า องศา celsius ให้เป็น Fahrenheit ได้สำเร็จ")]
        [InlineData(90, 194)]
        [InlineData(25, 77)]
        [InlineData(59, 138.20)]
        public void ConvertCelsiusToFahrenheitSuccess(double input, double expectedResult)
        {
            var cal = new TempCalculator();
            var x = cal.ConvertCelsiusToFahrenheit(input);

            x.Should().Be(expectedResult);
        }

        [Theory(DisplayName = "เปลี่ยนค่า องศา Kelvin ให้เป็น Fahrenheit ได้สำเร็จ")]
        [InlineData(90, -297.67)]
        [InlineData(100, -279.67)]
        [InlineData(46, -376.87)]
        public void ConvertKelvinToFahrenheitSuccess(double input, double expectedResult)
        {
            var cal = new TempCalculator();
            var x = cal.ConvertKelvinToFahrenheit(input);

            x.Should().Be(expectedResult);
        }

        [Theory(DisplayName = "เปลี่ยนค่า องศา Fahrenheit ให้เป็น Kelvin ได้สำเร็จ")]
        [InlineData(-297.67, 90)]
        public void ConvertFahrenheitToKelvinSuccess(double input, double expectedResult)
        {
            var cal = new TempCalculator();
            var x = cal.ConvertFahrenheitToKelvin(input);

            x.Should().Be(expectedResult);
        }

        [Theory(DisplayName = "เปลี่ยนค่า องศา celsius ให้เป็น Fahrenheit ได้สำเร็จ")]
        [InlineData(90, 363.15)]
        [InlineData(59, 332.15)]
        [InlineData(105, 378.15)]
        public void ConvertCelsiusToKelvinSuccess(double input, double expectedResult)
        {
            var cal = new TempCalculator();
            var x = cal.ConvertCelsiusToKelvin(input);

            x.Should().Be(expectedResult);
        }
    }
}