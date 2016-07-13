using System.Globalization;
using System.Threading;
using Xunit;

namespace UnitTest.String
{
    public class CurrencyTest
    {
        [Fact]
        public void CurrencyStringTest()
        {
            const int nro = 100;

            Thread.CurrentThread.CurrentCulture = new CultureInfo("fr-FR");

            var result = nro.ToString("c");

            Assert.Equal("100,00 €", result);

            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-GB");

            var result2 = nro.ToString("c");

            Assert.Equal("£100.00", result2);

            Thread.CurrentThread.CurrentCulture = new CultureInfo("fr-CH");

            var result3 = nro.ToString("c");

            Assert.Equal("fr. 100.00", result3);
        }
    }
}
