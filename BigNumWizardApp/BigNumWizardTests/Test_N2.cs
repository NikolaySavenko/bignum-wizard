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
        [InlineData("4354645635332423465777777777764646453433345", "yes")]
        [InlineData("100000000000000000000000000000000000000000000000000000000000", "yes")]
        [InlineData("1", "yes")]
        [InlineData("76655434323212343242", "yes")]
        [InlineData("10", "yes")]

        public void ZeroCheck(string target, string expexted)
        {
            var n1 = new BigNum(target);
            var n2 = N2_6.NZER_N_B(n1);
            Assert.Equal(n2.ToString(), expexted);
        }
    }
}