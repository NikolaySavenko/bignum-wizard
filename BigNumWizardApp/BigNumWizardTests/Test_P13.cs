using Xunit;
using BigNumWizardShared;
using System.Collections.Generic;

namespace BigNumWizardTests
{
    public class Test_P13
    {
        [Theory, MemberData(nameof(Data))]
        public static void ToSimple(BigNum m, List<BigFraction> a, Polynomial res)
        {
            var actual = P13.NMR_P_P(m, a);
            Assert.Equal(res.Odds[0], actual.Odds[0]);
        }
        public static IEnumerable<object[]> Data
        {
            get
            {
                return new[]
                {
                    new object[] {
                        new BigNum("2"),
                        new List<BigFraction>() { new BigFraction(BigNum.One), new BigFraction(new BigNum("-2")), new BigFraction(BigNum.One) },
                        new Polynomial(BigNum.One, new List<BigFraction>() { new BigFraction(BigNum.One), new BigFraction(BigNum.MinusOne) })
                    },
                    new object[] {
                        new BigNum("2"),
                        new List<BigFraction>() { new BigFraction(new BigNum("2")), new BigFraction(new BigNum("-4")), new BigFraction(new BigNum("2")) },
                        new Polynomial(BigNum.One, new List<BigFraction>() { new BigFraction(BigNum.One), new BigFraction(BigNum.MinusOne) })
                    },
                    new object[] {
                        new BigNum("5"),
                        new List<BigFraction>() { new BigFraction(BigNum.One), new BigFraction(new BigNum("-12")), new BigFraction(new BigNum("-18")), new BigFraction(new BigNum("324")), new BigFraction(new BigNum("729")), new BigFraction(BigNum.Zero) },
                        new Polynomial(new BigNum("3"), new List<BigFraction>() { new BigFraction(BigNum.One), new BigFraction(new BigNum("-6")), new BigFraction(new BigNum("-27")), new BigFraction(BigNum.Zero) })
                    },
                    new object[] {
                        BigNum.One,
                        new List<BigFraction>() { new BigFraction(new BigNum("7453444333333333333333333333333333")), new BigFraction(new BigNum("9834292489328792539688693235"))},
                        new Polynomial(BigNum.One, new List<BigFraction>() { new BigFraction(new BigNum("7453444333333333333333333333333333")), new BigFraction(new BigNum("9834292489328792539688693235")) })
                    },
                    new object[] {
                        new BigNum("6"),
                        new List<BigFraction>() { new BigFraction(BigNum.One), new BigFraction(new BigNum("40")), new BigFraction(new BigNum("150")), new BigFraction(new BigNum("-5000")), new BigFraction(new BigNum("15625")), new BigFraction(BigNum.Zero), new BigFraction(BigNum.Zero) },
                        new Polynomial(new BigNum("3"), new List<BigFraction>() { new BigFraction(BigNum.One), new BigFraction(new BigNum("20")), new BigFraction(new BigNum("-125")), new BigFraction(BigNum.Zero) })
                    },
                };
            }
        }
    }


}
