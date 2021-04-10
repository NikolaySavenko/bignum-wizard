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
