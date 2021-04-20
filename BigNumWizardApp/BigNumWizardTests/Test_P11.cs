using Xunit;
using BigNumWizardShared;
using System.Collections.Generic;

namespace BigNumWizardTests
{
    public class Test_P11 //Ivanov & Bratsun
    {
        [Theory, MemberData(nameof(Data))]
        public static void Polnod(BigNum m, List<BigFraction> a, BigNum n, List<BigFraction> b, Polynomial res)
        {

            var actual = P11.GCF_PP_P(m, a, n, b);
            Assert.Equal(res.Odds[0], actual.Odds[0]);
        }
        public static IEnumerable<object[]> Data
        {
            get
            {
                return new[]
                {

                     new object[] {
                        new BigNum("5"),
                        new List<BigFraction>() { new BigFraction(new BigNum("3")), new BigFraction(new BigNum("4")), new BigFraction(new BigNum("-4")), new BigFraction(new BigNum("-6")), new BigFraction(new BigNum("1")), new BigFraction(new BigNum("2")) },
                        new BigNum("4"),
                        new List<BigFraction>() { new BigFraction(new BigNum("3")), new BigFraction(new BigNum("7")), new BigFraction(new BigNum("0")), new BigFraction(new BigNum("-7")), new BigFraction(new BigNum("-3")) },
                        new Polynomial(new BigNum("2"), new List<BigFraction>() { new BigFraction(new BigNum("1")), new BigFraction(new BigNum("0")), new BigFraction(new BigNum("-1")) }) },
                     new object[] {
                        new BigNum("8"),
                        new List<BigFraction>() { new BigFraction(new BigNum("1")), new BigFraction(new BigNum("0")), new BigFraction(new BigNum("0")), new BigFraction(new BigNum("0")), new BigFraction(new BigNum("0")), new BigFraction(new BigNum("0")), new BigFraction(new BigNum("0")), new BigFraction(new BigNum("0")), new BigFraction(new BigNum("-1"))},
                        new BigNum("4"),
                        new List<BigFraction>(){ new BigFraction(new BigNum("1")), new BigFraction(new BigNum("0")), new BigFraction(new BigNum("0")), new BigFraction(new BigNum("0")), new BigFraction(new BigNum("-1")) },
                        new Polynomial(new BigNum("4"), new List<BigFraction>() { new BigFraction(new BigNum("1")), new BigFraction(new BigNum("0")), new BigFraction(new BigNum("0")), new BigFraction(new BigNum("-1")), new BigFraction(new BigNum("1")) })},
                    new object[] {
                        new BigNum("1"),
                        new List<BigFraction>(){ new BigFraction(new BigNum("2")), new BigFraction(new BigNum("-2"))},
                        new BigNum("2"),
                        new List<BigFraction>() { new BigFraction(new BigNum("1")), new BigFraction(new BigNum("-2")), new BigFraction(new BigNum("1"))},
                        new Polynomial(BigNum.One, new List<BigFraction>() { new BigFraction(new BigNum("1")), new BigFraction(new BigNum("-1")) }) },
                     new object[]
                    {
                        new BigNum("5"),
                        new List<BigFraction>() { new BigFraction(new BigNum("-123456789098765431234567890")), new BigFraction(BigNum.Zero), new BigFraction(BigNum.Zero), new BigFraction(BigNum.Zero), new BigFraction(BigNum.Zero), new BigFraction(new BigNum("123456789098765431234567890")) },
                        BigNum.Zero,
                        new List<BigFraction>(){new BigFraction(BigNum.One)},
                        new Polynomial(BigNum.Zero, new List<BigFraction>() { new BigFraction(new BigNum("1"))})
                    },
                    new object[]
                    {
                        new BigNum("4"),
                        new List<BigFraction>() { new BigFraction(new BigNum("1")), new BigFraction(new BigNum("1")), new BigFraction(new BigNum("-3")), new BigFraction(new BigNum("-4")), new BigFraction(new BigNum("-1"))},
                        new BigNum("4"),
                        new List<BigFraction>() { new BigFraction(new BigNum("1")), new BigFraction(new BigNum("1")), new BigFraction(new BigNum("0")), new BigFraction(new BigNum("-1")), new BigFraction(new BigNum("-1"))},
                        new Polynomial(BigNum.One, new List<BigFraction>() { new BigFraction(new BigNum("-1")), new BigFraction(new BigNum("-1"))})
                    },
                };
            }
        }
    }
}
