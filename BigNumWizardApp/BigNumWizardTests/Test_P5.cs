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
                    new object[] { new BigNum("2"), new List<BigFraction>() { new BigFraction(new BigNum("10")), new BigFraction(new BigNum("0")), new BigFraction(new BigNum("-9931231231232")) }, new BigFraction(new BigNum("10")) }
                };
            }
        }
    }
}
