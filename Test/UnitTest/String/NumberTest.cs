using System.Globalization;
using Xunit;

namespace UnitTest.String
{
    public class NumberTest
    {
        [Fact]
        public void DecimalTest()
        {
            const double nro = 1500.345;

            var result1 = nro.ToString();

            Assert.Equal("1500,345", result1);

            var result2 = nro.ToString(CultureInfo.CurrentCulture);

            Assert.Equal("1500,345", result2);

            var result3 = nro.ToString(new CultureInfo("en-US"));

            Assert.Equal("1500.345", result3);

            var result4 = nro.ToString(new CultureInfo("da-DK"));

            Assert.Equal("1500,345", result4);

            var result5 = nro.ToString(new CultureInfo("fr-CH"));

            Assert.Equal("1500.345", result5);

            var result6 = nro.ToString(CultureInfo.InvariantCulture);

            Assert.Equal("1500.345", result6);
        }

        [Fact]
        public void MilleTest()
        {
            const string numberFormat = "0,0";

            const int nro = 1500;

            var result1 = nro.ToString(numberFormat);

            Assert.Equal("1.500", result1);

            var result2 = nro.ToString(numberFormat, CultureInfo.CurrentCulture);

            Assert.Equal("1.500", result2);

            var result3 = nro.ToString(numberFormat, new CultureInfo("en-US"));

            Assert.Equal("1,500", result3);

            var result4 = nro.ToString(numberFormat, new CultureInfo("da-DK"));

            Assert.Equal("1.500", result4);

            var result5 = nro.ToString(numberFormat, new CultureInfo("fr-CH"));

            Assert.Equal("1'500", result5);

            var result6 = nro.ToString(numberFormat, CultureInfo.InvariantCulture);

            Assert.Equal("1,500", result6);
        }
    }
}
