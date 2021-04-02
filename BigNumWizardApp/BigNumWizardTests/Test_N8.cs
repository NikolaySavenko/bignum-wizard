using Xunit;
using BigNumWizardShared;

namespace BigNumWizardTests
{
    public class Test_N8 //Shvetc
    { 
        [Theory]
        [InlineData("1", "1", "1")]
        [InlineData("7", "6", "42")]
        [InlineData("15", "15", "225")]
        [InlineData("576", "123", "70848")]
        [InlineData("85476", "910", "77783160")]
        [InlineData("12", "987654321", "11851851852")]
        [InlineData("1000", "10", "10000")]
        [InlineData("10", "1080", "10800")]
        public void MuliplyByNatural(string target, string num, string expected)
        {
            Assert.Equal(N8_14.MUL_NN_N(new BigNum(target), new BigNum(num)), new BigNum(expected));
        }
    }
}
