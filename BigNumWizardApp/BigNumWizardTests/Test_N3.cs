using System;
using Xunit;
using BigNumWizardShared;

namespace BigNumWizardTests
{
    public class Test_N3 //Pukha
    {
        [Theory]
        [InlineData("12345679", "12345680")]
        [InlineData("5434543454345434", "5434543454345435")]
        [InlineData("9999999999", "10000000000")]
        [InlineData("112233445566999", "112233445567000")]
        [InlineData("0", "1")]
        [InlineData("9", "10")]
        [InlineData("8999999999999999999999999999999", "9000000000000000000000000000000")]
        [InlineData("999999999999999999999999999999999999", "1000000000000000000000000000000000000")]
        [InlineData("345664567475785785644569", "345664567475785785644570")]
        [InlineData("45646743634576678789995454211232342312", "45646743634576678789995454211232342313")]

        public void PlusOne(string target, string expexted)
        {
            Assert.Equal(N3_N7.ADD_1N_N(new BigNum(target)), new BigNum(expexted));
        }
    }
}
