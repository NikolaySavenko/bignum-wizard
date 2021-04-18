using BigNumWizardShared;
using Xunit;

namespace BigNumWizardTests
{
    public class IntConvertationTest
    {
        [Theory]
        [InlineData("122", 122)]
        [InlineData("0", 0)]
        [InlineData("21", 21)]
        [InlineData("12", 12)]
        [InlineData("64567456766545353", 64567456766545353)]
        [InlineData("-12", -12)]
        [InlineData("-1322", -1322)]
        [InlineData("-2345356364", -2345356364)]
        [InlineData("9", 9)]
        [InlineData("-4", -4)]


        public static void IntConvertation(string InputStr, int expected)
        {
            var Input = new BigNum(InputStr);
            Assert.Equal(expected, Input.ConvertToInt());
        }
    }
}
