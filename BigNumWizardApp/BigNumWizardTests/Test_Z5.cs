using Xunit;
using BigNumWizardShared;

namespace BigNumWizardTests
{
    public class Test_Z5 //Shvetc
    {
        [Theory]
        [InlineData("1", "1")]
        [InlineData("7", "7")]
        [InlineData("15", "15")]
        [InlineData("123", "123")]
        [InlineData("85476", "85476")]
        [InlineData("100", "100")]

        public void TranslateIntegerByNatural(string target, string expected)
        {
            Assert.Equal(Z4_5.TRANS_Z_N(new BigNum(target)), new BigNum(expected));
        }
    }
}