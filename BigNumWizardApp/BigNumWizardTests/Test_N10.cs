using System;
using System.Collections.Generic;
using System.Text;
using BigNumWizardShared;
using Xunit;

namespace BigNumWizardTests
{
    public class Test_N10 //Bratsun
    {

        [Theory]
        [InlineData("1", "1", "1")]
        [InlineData("10", "5", "2")]
        [InlineData("1568", "9", "100")]
        [InlineData("4567890", "2", "2000000")]
        [InlineData("9", "9999999999999999", "1000000000000000")]
        [InlineData("15678987654567890", "14587", "1000000000000")]
        [InlineData("3123", "3123", "1")]
        [InlineData("31241343", "4", "7000000")]
        [InlineData("31241343234243422534535645645634534534645745634534645745645645", "57345414587654567890567890", "50000000000000000000000000000000000")] //не работает
        [InlineData("92872463824762384623847236487236432746742384", "14587654567890567890", "6000000000000000000000000")]//не работает
        public void FirstNumber(string num1, string num2, string expected)
        {
            var n1 = new BigNum(num1);
            var n2 = new BigNum(num2);
            var exp = new BigNum(expected);
            var result = N10.DIV_NN_Dk(n1, n2);
            Assert.Equal(result, exp);
        }
    }
}
