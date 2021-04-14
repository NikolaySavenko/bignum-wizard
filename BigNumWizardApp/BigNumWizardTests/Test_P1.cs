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

        public static void MultiplyPolynomOnQ(BigNum m1, List<BigFraction> c1, BigNum m2, List<BigFraction> c2, Polynomial res)
        {
            var actualPolynom = P1_2.ADD_PP_P(m1, c1, m2, c2);

            Assert.Equal(res, actualPolynom);
        }

        public static IEnumerable<object[]> Data
        {
            get
            {
                return new[]
                {
                    
                    new object[] {
                        BigNum.One,
                        new List<BigFraction>() { new BigFraction(new BigNum("5"), new BigNum("149")), new BigFraction(new BigNum("8"), new BigNum("973")) },
                        BigNum.One,
                        new List<BigFraction>() { new BigFraction(BigNum.One, new BigNum("308")), new BigFraction(new BigNum("5"), new BigNum("441")) },
                        new Polynomial(BigNum.One, new List<BigFraction>() { new BigFraction(new BigNum("1689"), new BigNum("45892")), new BigFraction(new BigNum("1199"), new BigNum("61299")) })
                    },
                };
            }
        }
    }
}
