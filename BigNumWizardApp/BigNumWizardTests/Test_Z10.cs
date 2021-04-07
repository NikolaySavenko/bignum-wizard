using Xunit;
using BigNumWizardShared;

namespace BigNumWizardTests
{
    public class Test_Z10
    {
        [Theory]
        [InlineData("100", "2", "0")]
        [InlineData("5000", "3000", "2000")]
        [InlineData("500000001", "2", "1")]
        [InlineData("45", "100", "45")]
        [InlineData("-100", "50", "0")]
        [InlineData("-100", "55", "10")]


        public void Rest_of_divide(string target, string num, string expexted)
        {

            var n1 = new BigNum(target);
            var n2 = new BigNum(num);
            var sum = Z10.MOD_ZZ_Z(n1, n2, out _);

            Assert.Equal(sum, new BigNum(expexted));
        }
    }
}
