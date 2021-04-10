using BigNumWizardShared;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BigNumWizardTests
{
    public class Test_P2
    {
        [Theory, MemberData(nameof(Data))]

        public static void MultiplyPolynomOnQ(int m1, List<BigFraction> c1, int m2, List<BigFraction> c2, Polynomial res)
        {
            var actualPolynom = P1_2.SUB_PP_P(m1, c1, m2, c2);

            Assert.Equal(res.Odds, actualPolynom.Odds); 
            Assert.Equal(res.SeniorDegree, actualPolynom.SeniorDegree); 
        }

        public static IEnumerable<object[]> Data
        {
            get
            {
                return new[]
                {
                    new object[] {
                        1,
                        new List<BigFraction>() { new BigFraction(new BigNum("2")), new BigFraction(new BigNum("5")) },
                        1,
                        new List<BigFraction>() { new BigFraction(BigNum.One), new BigFraction(new BigNum("3")) },
                        new Polynomial(BigNum.One, new List<BigFraction>() { new BigFraction(new BigNum("1")), new BigFraction(new BigNum("2")) })
                    },
                    new object[] {
                        1,
                        new List<BigFraction>() { new BigFraction(new BigNum("2"), new BigNum("5")), new BigFraction(new BigNum("5"), new BigNum("8")) },
                        1,
                        new List<BigFraction>() { new BigFraction(BigNum.One, new BigNum("12")), new BigFraction(new BigNum("2"), new BigNum("13")) },
                        new Polynomial(BigNum.One, new List<BigFraction>() { new BigFraction(new BigNum("19"), new BigNum("60")), new BigFraction(new BigNum("49"), new BigNum("104")) })
                    },
                    new object[] {
                        1,
                        new List<BigFraction>() { new BigFraction(new BigNum("2"), new BigNum("5")), new BigFraction(new BigNum("5"), new BigNum("8")) },
                        1,
                        new List<BigFraction>() { new BigFraction(new BigNum("2"), new BigNum("5")), new BigFraction(new BigNum("5"), new BigNum("8")) },
                        new Polynomial(BigNum.One, new List<BigFraction>() { new BigFraction(BigNum.Zero), new BigFraction(BigNum.Zero) })
                    },
                    new object[] {
                        1,
                        new List<BigFraction>() { new BigFraction(new BigNum("-2")), new BigFraction(new BigNum("5")) },
                        1,
                        new List<BigFraction>() { new BigFraction(BigNum.One), new BigFraction(new BigNum("3")) },
                        new Polynomial(BigNum.One, new List<BigFraction>() { new BigFraction(new BigNum("-3")), new BigFraction(new BigNum("2")) })
                    },
                    new object[] {
                        1,
                        new List<BigFraction>() { new BigFraction(new BigNum("10000000000001")), new BigFraction(new BigNum("5")) },
                        1,
                        new List<BigFraction>() { new BigFraction(BigNum.One), new BigFraction(new BigNum("3")) },
                        new Polynomial(BigNum.One, new List<BigFraction>() { new BigFraction(new BigNum("10000000000000")), new BigFraction(new BigNum("2")) })
                    },
                    new object[] {
                        1,
                        new List<BigFraction>() { new BigFraction(new BigNum("-123456789")), new BigFraction(new BigNum("-5")) },
                        1,
                        new List<BigFraction>() { new BigFraction(BigNum.One), new BigFraction(new BigNum("30020")) },
                        new Polynomial(BigNum.One, new List<BigFraction>() { new BigFraction(new BigNum("-123456790")), new BigFraction(new BigNum("-30025")) })
                    },
                    new object[] {
                        1,
                        new List<BigFraction>() { new BigFraction(new BigNum("2000020000200002")), new BigFraction(new BigNum("-5000000000000"), new BigNum("-8000000000000")) },
                        1,
                        new List<BigFraction>() { new BigFraction(new BigNum("2")), new BigFraction(new BigNum("-5000000000000"), new BigNum("-8000000000000")) },
                        new Polynomial(BigNum.One, new List<BigFraction>() { new BigFraction(new BigNum("2000020000200000")), new BigFraction(BigNum.Zero) })
                    },
                    new object[] {
                        1,
                        new List<BigFraction>() { new BigFraction(new BigNum("111111111111111112")), new BigFraction(new BigNum("685437866435")) },
                        1,
                        new List<BigFraction>() { new BigFraction(new BigNum("111111111111111110")), new BigFraction(new BigNum("685437866425")) },
                        new Polynomial(BigNum.One, new List<BigFraction>() { new BigFraction(new BigNum("2")), new BigFraction(BigNum.Ten) })
                    },

                };
            }
        }
    }
}
