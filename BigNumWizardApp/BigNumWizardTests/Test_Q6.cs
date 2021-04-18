using Xunit;
using BigNumWizardShared;

namespace BigNumWizardTests
{
    public class Test_Q6 //Bratsun
    {
        [Theory]
        [InlineData("1", "2", "1", "2", "0", "1")]
        [InlineData("3232", "12213", "6578", "8888", "-2345959", "4934052")]
        [InlineData("9999", "32125", "-7777", "27920", "105801641", "179386000")]
        [InlineData("-6666", "9002", "6545", "33322", "-140521271", "149982322")]
        [InlineData("222222222222222222222222222222222222", "333333333333333333333333333333333333", "111111111111111111111111111111111111", "333333333333333333333333333333333333", "1", "3")]
        [InlineData("-6543", "765432", "123434", "92222999", "-77543935105", "7843381618952")]
        [InlineData("2", "3", "1", "3", "1", "3")]
        [InlineData("-545353", "23232", "453345", "653464", "-45862582979", "1897659456")]
        [InlineData("-53456346345635345245255", "63456656353543556353454", "-234213412311341313144", "345366353454653463523", "-3599623387969476327581242817005923071333989", "21915794007248405279169748423598793084058442")]
        [InlineData("23435353453534342", "-1312324543455", "6545434234", "3534524234", "-41420707223932786763941249", "2319221450857341794235")]


        public void FractionsSum(string FirNom, string FirDenom, string SecNom, string SecDenom, string resNom, string resDenom)
        {
            BigFraction fir = new BigFraction(new BigNum(FirNom), new BigNum(FirDenom));
            BigFraction sec = new BigFraction(new BigNum(SecNom), new BigNum(SecDenom));
            BigFraction res = new BigFraction(new BigNum(resNom), new BigNum(resDenom));
            Assert.Equal(res, Q6.SUB_QQ_Q(fir, sec));
        }
    }

}
