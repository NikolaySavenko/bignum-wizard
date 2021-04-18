using Xunit;
using BigNumWizardShared;

namespace BigNumWizardTests
{
    public class Test_Q7    // Osiptsov
    {
        [Theory]
        [InlineData("1", "1", "1", "1", "1", "1")]
        [InlineData("0", "234", "23454523423452234423", "2", "0", "468")]
        [InlineData("-123341223123", "-23234554", "-123445", "321", "15225857288418735", "-7458291834")]
        [InlineData("233423435", "6756453534323", "132453214563212", "355425125", "30917684320136969673220", "2401413341993444065375")]
        [InlineData("-23452341", "351252525234", "1341313245", "100000000000000000000000", "-31456935609556545", "35125252523400000000000000000000000")]
        [InlineData("-35253543534", "-12346897854443", "-45645765533256334663", "-4656535231111234423000005432", "1609174982369408918823343719042", "57493764854145539440011972159738145334376")]
        [InlineData("-34532423532", "112345234234", "656542234324", "-34", "-22671994502321955712368", "-3819737963956")]
        [InlineData("-3453535325", "45534534342455342", "113453456345", "234242454354", "-391815519230802887125", "10666121082243240852718459068")]
        [InlineData("-3455554", "1", "-12324234", "1", "42587056095636", "1")]
        [InlineData("345353454522325242", "112312342", "1117886997570000", "9999942423527867", "386066136376389703314403661940000", "1123116953451570645034514")]

        public void FractionsMultiply(string FirNom, string FirDenom, string SecNom, string SecDenom, string resNom, string resDenom)
        {
            BigFraction fir = new BigFraction(new BigNum(FirNom), new BigNum(FirDenom));
            BigFraction sec = new BigFraction(new BigNum(SecNom), new BigNum(SecDenom));
            BigFraction res = new BigFraction(new BigNum(resNom), new BigNum(resDenom));
            Assert.Equal(Q5_7.MUL_QQ_Q(fir, sec), res);
        }
    }
}