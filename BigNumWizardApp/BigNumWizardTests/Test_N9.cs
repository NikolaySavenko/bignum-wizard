using Xunit;
using BigNumWizardShared;
using System.Collections.Generic;
using System;
using System.Text;

namespace BigNumWizardTests
{
    public class Test_N9 //Lukina
    {
        [Theory]
        [InlineData("6", "2", 2, "2")]
        [InlineData("1000", "50", 10, "500")]
        [InlineData("78000", "920", 9, "69720")]
        [InlineData("78910", "9", 2, "78892")]
        [InlineData("999999999", "123456789", 8, "12345687")]
        [InlineData("99", "999", 8, "207")]
        [InlineData("999888777666", "123456789", 9, "998777666565")]
        [InlineData("98765432123456789", "5678912345678901", 17, "2223922246915472")]
        [InlineData("123", "123456", 10, "122226")]
        [InlineData("111", "999", 9, "0")]
        [InlineData("111", "999", 0, "999")]
        [InlineData("12345678909876", "965", 0, "12345678909876")] //actual 965
        [InlineData("7800075797", "920", 0, "7800075797")] //actual 920
        [InlineData("1111111111111111111", "123654789", 17, "1111111109008979698")]
        public static void MultOf3(string num1, string num2, byte k, string expected)
        {
            var t = N9.SUB_NDN_N(new BigNum(num1), new BigNum(num2), k);
            
            Assert.Equal(new BigNum(expected), t );
        }
    }
}
