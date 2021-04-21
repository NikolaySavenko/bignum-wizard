using Xunit;
using BigNumWizardShared;

namespace BigNumWizardTests
{
    public class Test_Q7    // Osiptsov
    {
        [Theory]
        [InlineData("1", "1", "1", "1", "1", "1")]
        [InlineData("0", "234", "23454523423452234423", "2", "0", "1")]
        [InlineData("-123341223123", "-23234554", "-123445", "321", "725040823258035", "-355156754")]
        [InlineData("233423435", "6756453534323", "132453214563212", "355425125", "6183536864027393934644", "480282668398688813075")]
        [InlineData("-23452341", "351252525234", "1341313245", "100000000000000000000000", "-2097129040637103", "2341683501560000000000000000000000")]
        [InlineData("-35253543534", "-12346897854443", "-45645765533256334663", "-4656535231111234423000005432", "268195830394901486470557286507", "9582294142357589906668662026623024222396")]
        [InlineData("-34532423532", "112345234234", "656542234324", "-34", "-5667998625580488928092", "-954934490989")]
        [InlineData("-3453535325", "45534534342455342", "113453456345", "234242454354", "-391815519230802887125", "10666121082243240852718459068")]
        [InlineData("-3455554", "1", "-12324234", "1", "42587056095636", "1")]
        [InlineData("345353454522325242", "112312342", "1117886997570000", "9999942423527867", "193033068188194851657201830970000", "561558476725785322517257")]

        public void FractionsMultiply(string FirNom, string FirDenom, string SecNom, string SecDenom, string resNom, string resDenom)
        {
            BigFraction fir = new BigFraction(new BigNum(FirNom), new BigNum(FirDenom));
            BigFraction sec = new BigFraction(new BigNum(SecNom), new BigNum(SecDenom));
            BigFraction res = new BigFraction(new BigNum(resNom), new BigNum(resDenom));
            Assert.Equal(Q5_7.MUL_QQ_Q(fir, sec), res);
        }
    }
}