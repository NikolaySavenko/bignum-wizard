using Xunit;
using BigNumWizardShared;

namespace BigNumWizardTests
{
    public class Test_Q8 //Petrakova
    {
        [Theory]
        [InlineData("0","1","35543","2","0","35543")]
        [InlineData("0","4328","-11111","932847","0","-48088408")]
        [InlineData("0", "-8887323", "-34342232", "13270006", "0", "305210508324936")]
        [InlineData("0","6667217","181728","-3711721","0", "-1211620010976")]
        [InlineData("2635","763253","461","826218","2177084430","351859633")]
        [InlineData("-423118472","45","7561811462185","147851","-62558489203672","340281515798325")]
        [InlineData("26423423","-83442","32843231","1900","-50204503700","2740504881102")]
        [InlineData("18133","121932812","-213963","9817137313","-178014150896629","26089110253956")]
        [InlineData("45931","90083435","193732","-88463777","-4063229741387","17452044029420")]
        [InlineData("111222","-283274213000","1818183737","-82355555", "9159749538210", "515044567188073981000")]
        [InlineData("2281755832825375","1","1","-73748249723", "-168275498966117596151121125","1")]
        [InlineData("77777777777","1","12345678987654321","1", "77777777777", "12345678987654321")]
        [InlineData("437","100000000000000000000000000000000000000","56473228","-1","-437","5647322800000000000000000000000000000000000000")]
        [InlineData("-1","-1","-1","-1","1","1")]

        public void FractionsDivision(string nom_1, string denom_1, string nom_2, string denom_2, string nom_res, string denom_res)
        {
            BigFraction first = new BigFraction(new BigNum(nom_1), new BigNum(denom_1));
            BigFraction second = new BigFraction(new BigNum(nom_2), new BigNum(denom_2));
            BigFraction result = new BigFraction(new BigNum(nom_res), new BigNum(denom_res));

            Assert.Equal(Q8.DIV_QQ_Q(first, second), result);
        }
    }
}
