using System;
using System.Globalization;
using Xunit;

namespace UnitTest.String
{
    public class CustomCulture
    {
        [Fact]
        public void CustomCultureTest()
        {
            const string numberFormat = "0,0";

            const int nro = 1500;

            var cultureInfo = new CultureInfo("en-US")
            {
                NumberFormat = {NumberGroupSeparator = "-"}
            };

            var result1 = nro.ToString(numberFormat, cultureInfo);

            Assert.Equal("1-500", result1);
        }

        [Fact]
        public void InvariantCustomCultureTest()
        {
            var invariantCultureInfo = CultureInfo.InvariantCulture;

            var exception = Assert.Throws<InvalidOperationException>(() =>
            {
                invariantCultureInfo.NumberFormat.NumberGroupSeparator = "-";
            });

            Assert.Equal("Instance is read-only.", exception.Message);
        }
    }
}
