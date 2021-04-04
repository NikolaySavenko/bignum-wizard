using Xunit;
using BigNumWizardShared;

namespace BigNumWizardTests
{
    public class Test_N11
    {
        [Theory]
        [InlineData("15", "3", "5")]
        [InlineData("11111999999","2", "5555999999")]
        [InlineData("11111999999000000","1","11111999999000000")]
        [InlineData("123456789","9","13717421")] 
        [InlineData("2","2","1")]
        [InlineData("888","44","20")] 
        [InlineData("89", "4", "22")]
        [InlineData("900000000000","3", "300000000000")]
        [InlineData("15000","1", "15000")]
        [InlineData("1111111111111111111111111","9999999999","111111111122222")]
        [InlineData("18","1","18")]
        [InlineData("1","8743274788724432","0")]
        [InlineData("832872332478","38565534","21596")]
        [InlineData("4329884327742293","999999999999999999999999999","0")]
        [InlineData("999999999999999999999999","117777774", "8490566310074768")]
        [InlineData("112233445566778899","1234567890", "90909091")]
        [InlineData("73432884943328972489732743783879234893423479823847","8328732782433879897378342789923929292999999292929929929","0")]
        [InlineData("17","38784878243243449243385537883448394383943434636347","0")]
        [InlineData("1277324874838498432", "1277324874838498431","1")]

        public static void Dividing(string num1, string num2, string res)
        {
            Assert.Equal(N11.DIV_NN_N(new BigNum(num1), new BigNum(num2), out BigNum remainer), new BigNum(res));
        }
    }
}
