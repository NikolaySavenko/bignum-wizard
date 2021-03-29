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

        public void PlusOne(string target, string expexted)
        {
            Assert.Equal(N3_N7.ADD_1N_N(new BigNum(target)), new BigNum(expexted));
        }
    }
}
