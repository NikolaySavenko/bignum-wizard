using Xunit;
using BigNumWizardShared;

namespace BigNumWizardTests
{
    public class test_Q5
    {
        [Theory]
        [InlineData("1", "1", "1", "1", "2", "1")]
        [InlineData("5353", "4342", "8877", "4535", "62819789", "19690970")]
        [InlineData("5353", "4342", "-5353", "4342", "0", "1")]
        [InlineData("6554", "-9999", "6545", "3332", "43605527", "33316668")]
        [InlineData("17", "25", "8", "25", "25", "25")]
        [InlineData("-4555", "-2345", "1234", "9999", "48439175", "23447655")]
        [InlineData("-4555", "-2345", "1234", "-9999", "42651715", "23447655")]
        [InlineData("111111111111111111111111111", "66666666666666666666666666", "555555555555555555555555555", "6666666666666666666666666", "1", "1")]
        [InlineData("-9999", "3442", "4434", "2211", "-6845961", "7610262")]
        [InlineData("-332", "16", "333", "16", "1", "16")]


        public void FractionsSum(string FirNom, string FirDenom, string SecNom, string SecDenom, string resNom, string resDenom)
        {
            BigFraction fir = new BigFraction(new BigNum(FirNom), new BigNum(FirDenom));
            BigFraction sec = new BigFraction(new BigNum(SecNom), new BigNum(SecDenom));
            BigFraction res = new BigFraction(new BigNum(resNom), new BigNum(resDenom));
            Assert.Equal(res, Q5_7.ADD_QQ_Q(fir, sec));
        }
    }

}
