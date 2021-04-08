using Xunit;
using BigNumWizardShared;

namespace BigNumWizardTests
{
    public class test_Q5    // Osiptsov
    {
        [Theory]
        [InlineData("1", "1", "1", "1", "2", "1")]
        [InlineData("5353", "4342", "8877", "4535", "62819789", "19690970")]
        [InlineData("5353", "4342", "-5353", "4342", "0", "1")]
        [InlineData("6554", "-9999", "6545", "3332", "366433", "279972")]
        [InlineData("17", "25", "8", "25", "1", "1")]
        [InlineData("-4555", "-2345", "1234", "9999", "9687835", "4689531")]
        [InlineData("-4555", "-2345", "1234", "-9999", "8530343", "4689531")]
        [InlineData("11111111111111111111111111111111111111111111111111", "66666666666666666666666666666666666666666666666666", "55555555555555555555555555555555555555555555555555", "66666666666666666666666666666666666666666666666666", "1", "1")]
        [InlineData("-9999", "3442", "4434", "2211", "-2281987", "2536754")]
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
