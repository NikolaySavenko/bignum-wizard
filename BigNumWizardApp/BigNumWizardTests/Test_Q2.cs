using System;
using Xunit;
using BigNumWizardShared;

namespace BigNumWizardTests
{
    public class Test_Q2 //Solovieva
    {
        [Theory]
        [InlineData("5", "3", "No")]
        [InlineData("98765432123456789", "1", "Yes")]
        [InlineData("777", "259", "Yes")]
        [InlineData("444444444", "222222222", "Yes")]
        [InlineData("734567898765432456789009876543210", "5", "Yes")]
        [InlineData("50959854608945687", "2", "No")]
        [InlineData("-1234576785554433766543245678900987654321000", "1000", "Yes")]
        [InlineData("-509598546089456879000000000000000000000000000000000000000000", "-1000000000000000000000000000000000000000", "Yes")]
        [InlineData("-123456", "2", "Yes")]
        [InlineData("66666666666666666666", "-3", "Yes")]
        [InlineData("50959854608945687", "-23434453455456565465655675567756", "No")]


        public void IntCheck(string target1, string target2, string expexted)
        {
            var n1 = new BigNum(target1);
            var n2 = new BigNum(target2);
            var n3 = Q2_3.INT_Q_B(n1,n2);
            Assert.Equal((string)n3, expexted);
        }
    }
}