using Xunit;
using BigNumWizardShared;
using System.Collections.Generic;

namespace BigNumWizardTests
{
    public class Test_P5 //Bratsun
    {
        [Theory, MemberData(nameof(Data))]

        public static void Starsh_Koef_Pol(BigNum m, List<BigFraction> C, BigFraction res)
        {
            BigFraction actual = P4_5.LED_P_Q(m, C);
            Assert.Equal(actual, res);
        }
        public static IEnumerable<object[]> Data
        {
            get
            {
                return new[]
                {
                    new object[] { BigNum.One, new List<BigFraction>() { new BigFraction(new BigNum("13131")), new BigFraction(new BigNum("23123")) }, new BigFraction(new BigNum("13131")) },
                    new object[] { new BigNum("6"), new List<BigFraction>() { new BigFraction(new BigNum("-8934923498")), new BigFraction(new BigNum("89259245987249572458")), new BigFraction(new BigNum("-9888436748888888888888734373738")), new BigFraction(new BigNum("923442376")), new BigFraction(new BigNum("181111111111111110")), new BigFraction(new BigNum("432333333333333333")), new BigFraction(new BigNum("0")) }, new BigFraction(new BigNum("-8934923498"))},
                    new object[] { new BigNum("5"), new List<BigFraction>() { new BigFraction(new BigNum("4542222222222222222222223")), new BigFraction(new BigNum("213123121")), new BigFraction(new BigNum("11112312331231")), new BigFraction(new BigNum("5465464565448")), new BigFraction(new BigNum("84623423333")), new BigFraction(new BigNum("2323424342")) }, new BigFraction(new BigNum("4542222222222222222222223"))},
                    new object[] { BigNum.Zero, new List<BigFraction>() { new BigFraction(new BigNum("122222222223131232")) }, new BigFraction(new BigNum("122222222223131232"))},
                    new object[] { new BigNum("8"), new List<BigFraction>() { new BigFraction(new BigNum("0")), new BigFraction(new BigNum("131231231232")), new BigFraction(new BigNum("8300031231230000000002")), new BigFraction(new BigNum("10")), new BigFraction(new BigNum("0")), new BigFraction(new BigNum("1227331234246")), new BigFraction(new BigNum("0")), new BigFraction(new BigNum("501")), new BigFraction(new BigNum("126123")) }, new BigFraction(new BigNum("0"))},
                    new object[] { new BigNum("2"), new List<BigFraction>() { new BigFraction(new BigNum("10")), new BigFraction(new BigNum("0")), new BigFraction(new BigNum("-9931231231232")) }, new BigFraction(new BigNum("10")) },
                    new object[] { new BigNum("21"), new List<BigFraction>() { new BigFraction(new BigNum("193"), new BigNum("30")), new BigFraction(new BigNum("202"), new BigNum("317")), new BigFraction(new BigNum("212"), new BigNum("164")), new BigFraction(new BigNum("205"), new BigNum("171")), new BigFraction(new BigNum("188"), new BigNum("309")), new BigFraction(new BigNum("180"), new BigNum("283")), new BigFraction(new BigNum("221"), new BigNum("163")), new BigFraction(new BigNum("324"), new BigNum("228")), new BigFraction(new BigNum("293"), new BigNum("29")), new BigFraction(new BigNum("18"), new BigNum("225")), new BigFraction(new BigNum("254"), new BigNum("24")), new BigFraction(new BigNum("87"), new BigNum("28")), new BigFraction(new BigNum("191"), new BigNum("313")), new BigFraction(new BigNum("34"), new BigNum("21")), new BigFraction(new BigNum("15"), new BigNum("62")), new BigFraction(new BigNum("217"), new BigNum("192")), new BigFraction(new BigNum("329"), new BigNum("195")), new BigFraction(new BigNum("18"), new BigNum("231")), new BigFraction(new BigNum("139"), new BigNum("342")), new BigFraction(new BigNum("36"), new BigNum("58")), new BigFraction(new BigNum("205"), new BigNum("44")), new BigFraction(new BigNum("59"), new BigNum("12")), }, new BigFraction(new BigNum("193"), new BigNum("30"))},
                    new object[] { new BigNum("5"), new List<BigFraction>() { new BigFraction(new BigNum("2198857747218842319"), new BigNum("3392420516287707475")), new BigFraction(new BigNum("1023478343872540747"), new BigNum("1775772728268114471")), new BigFraction(new BigNum("3195272739229255346"), new BigNum("3597942293740818541")), new BigFraction(new BigNum("2449265822380443509"), new BigNum("5404348952976071186")), new BigFraction(new BigNum("1447861946087499188"), new BigNum("3123053005170543393")), new BigFraction(new BigNum("212163168525099254"), new BigNum("3218550944664606683")), }, new BigFraction(new BigNum("2198857747218842319"), new BigNum("3392420516287707475"))},
                    new object[] { new BigNum("12"), new List<BigFraction>() { new BigFraction(new BigNum("3773246296728465249"), new BigNum("3631631265242262700")), new BigFraction(new BigNum("-646961102299233344"), new BigNum("4577632915093177416")), new BigFraction(new BigNum("3420752512182749089"), new BigNum("1447532484483878656")), new BigFraction(new BigNum("4596948171362376098"), new BigNum("1205475659524109979")), new BigFraction(new BigNum("1061641682541259205"), new BigNum("-1536159376741337875")), new BigFraction(new BigNum("-3085355253808577140"), new BigNum("4424515872450535677")), new BigFraction(new BigNum("4571728049651247245"), new BigNum("492834114108482599")), new BigFraction(new BigNum("264592466859267892"), new BigNum("3192142379701492103")), new BigFraction(new BigNum("-66189412704724920"), new BigNum("4891844824111755409")), new BigFraction(new BigNum("-888786324527956503"), new BigNum("3431240175674458848")), new   BigFraction(new BigNum("-1830175418000624279"), new BigNum("-975090871432696805")), new BigFraction(new BigNum("-1223681624968305404  "), new BigNum("5321152411696238886")), new BigFraction(new BigNum("4443537153991994632"), new BigNum("3648247270246045147")), }, new   BigFraction(new BigNum("3773246296728465249"), new BigNum("3631631265242262700"))},
                    new object[] { new BigNum("3"), new List<BigFraction>() { new BigFraction(new BigNum("2875723332281260633"), new BigNum("-2628551579576965066")), new BigFraction(new BigNum("-209499265158260571"), new BigNum("3921625794493093070")), new BigFraction(new BigNum("-515125481590621172"), new BigNum("-1512924354950931105")), new BigFraction(new BigNum("-2759548049024821223"), new BigNum("998623140903401730")), }, new BigFraction(new BigNum("2875723332281260633"), new BigNum("-2628551579576965066"))},
                };
            }
        }
    }
}
