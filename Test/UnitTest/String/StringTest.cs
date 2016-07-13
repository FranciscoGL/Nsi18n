using System;
using System.Globalization;
using System.Threading;
using Xunit;

namespace UnitTest.String
{
    public class StringTest
    {
        [Fact]
        public void StringOrder()
        {
            string[] stringArray = { "A", "Æ", "Z" };

            Thread.CurrentThread.CurrentCulture = new CultureInfo("da-DK");
            Array.Sort(stringArray);
            var result1 = string.Join("-", stringArray);

            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Array.Sort(stringArray);
            var result2 = string.Join("-", stringArray);

            Assert.Equal("A-Z-Æ", result1);
            Assert.Equal("A-Æ-Z", result2);
        }
    }
}
