using Xunit;
using BigNumWizardShared;

namespace BigNumWizardTests
{
    public class Test_N14 //Shvetc
    {
        [Theory]
        [InlineData("5", "10", "10")]
        [InlineData("12", "6", "12")]
        [InlineData("1", "5", "5")]
        [InlineData("1", "1", "1")]
        [InlineData("18", "153", "306")]
        [InlineData("5", "5", "5")]
        [InlineData("34", "132", "2244")]
        [InlineData("56", "13", "728")]
        [InlineData("12426", "6233", "77451258")]
        [InlineData("240", "56", "1680")]
        [InlineData("565656", "131313", "7353528")]
        [InlineData("555555555", "111", "555555555")]
        [InlineData("1111", "555555555", "617222221605")]
        [InlineData("3", "2", "6")]


        public void LeastCommonMultiple(string target, string num, string expected)
        {

            Assert.Equal(N8_14.LCM_NN_N(new BigNum(target), new BigNum(num)), new BigNum(expected));
        }
    }
}