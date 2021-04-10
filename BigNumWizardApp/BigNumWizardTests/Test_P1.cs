using BigNumWizardShared;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BigNumWizardTests
{
    public class Test_P1
    {
        [Theory, MemberData(nameof(Data))]

        public static void MultiplyPolynomOnQ(int m1, List<BigFraction> c1, int m2, List<BigFraction> c2, Polynomial res)
        {
            var actualPolynom = P1_2.ADD_PP_P(m1, c1, m2, c2);

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
                        new List<BigFraction>() { new BigFraction(BigNum.One), new BigFraction(new BigNum("5")) },
                        1,
                        new List<BigFraction>() { new BigFraction(BigNum.One), new BigFraction(new BigNum("5")) },
                        new Polynomial(BigNum.One, new List<BigFraction>() { new BigFraction(new BigNum("2")), new BigFraction(new BigNum("10")) })
                    },
                    new object[] {
                        1,
                        new List<BigFraction>() { new BigFraction(new BigNum("5"), new BigNum("149")), new BigFraction(new BigNum("8"), new BigNum("973")) },
                        1,
                        new List<BigFraction>() { new BigFraction(BigNum.One, new BigNum("308")), new BigFraction(new BigNum("5"), new BigNum("441")) },
                        new Polynomial(BigNum.One, new List<BigFraction>() { new BigFraction(new BigNum("1689"), new BigNum("45892")), new BigFraction(new BigNum("1199"), new BigNum("61299")) })
                    },
                };
            }
        }
    }
}
