using System;
using Xunit;
using BigNumWizardShared;

namespace BigNumWizardTests
{
    public class Test_N2 //Lukina
    {
        [Theory]
        [InlineData("0", "no")]
        [InlineData("98765432123456789", "yes")]
        [InlineData("7", "yes")]
        [InlineData("444444444", "yes")]
        [InlineData("73456789876543245678900987654321", "yes")]

        public void ZeroCheck(string target, string expexted)
        {
            var n1 = new BigNum(target);
            var n2 = N2_6.NZER_N_B(n1);
            Assert.Equal(n2.ToString(), expexted);
        }
    }
}