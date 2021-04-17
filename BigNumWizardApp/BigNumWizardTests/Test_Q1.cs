using Xunit;
using BigNumWizardShared;

namespace BigNumWizardTests
{
    public class Test_Q1 //Petrakova
    {
        [Theory]
        [InlineData("2", "4", "1", "2")]
        [InlineData("4","2","2","1")]
        [InlineData("-108324", "843401", "-108324", "843401")]
        [InlineData("0", "54", "0", "1")]
        [InlineData("-111111111111", "1111", "-100010001", "1")]
        [InlineData("-1234567890987654321", "11111111018888888889", "-1", "9")]
        [InlineData("123456789", "123456789", "1", "1")]
        [InlineData("-8888888888", "8888888888", "-1", "1")]
        [InlineData("55555555555555555", "-5", "-11111111111111111", "1")]
        [InlineData("43632", "-48", "-909", "1")]
        [InlineData("-123456789123456789", "3", "-41152263041152263", "1")] 
        [InlineData("-1234567890000123456789", "411522630000041152263", "-3", "1")]
        [InlineData("953714708885599404870223", "-343433456566654448999", "-2777","1")] 

        public static void Reduction(string nom1, string denom1, string nom_exp, string denom_exp)
        {
            BigFraction fraction = new BigFraction(new BigNum(nom1), new BigNum(denom1));
            BigFraction fraction_exp = new BigFraction(new BigNum(nom_exp), new BigNum(denom_exp));
            BigFraction res = Q1.RED_Q_Q(fraction);
            Assert.Equal(fraction_exp, res);
        }
    }
}