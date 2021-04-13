using Xunit;
using BigNumWizardShared;
using System.Collections.Generic;

namespace BigNumWizardTests
{
    public class Test_P9
    {
        [Theory, MemberData(nameof(Data))]

        public static void QuotientPolynomial(BigNum m1, List<BigFraction> C1, BigNum m2, List<BigFraction> C2, Polynomial result)
        {
            Polynomial quotient = P9.DIV_PP_P(m1, C1, m2, C2);
            Assert.Equal(result, quotient);
        }

        public static IEnumerable<object[]> Data
        {
            get
            {
                return new[]
                {
                    new object[] {
                        new BigNum("3"),
                        new List<BigFraction>() { new BigFraction(BigNum.One), new BigFraction(new BigNum("2")), new BigFraction(new BigNum("3")), new BigFraction(new BigNum("4")) },
                        new BigNum("2"),
                        new List<BigFraction>() { new BigFraction(BigNum.One), new BigFraction(new BigNum("2")), new BigFraction(new BigNum("3")) },
                        new Polynomial(BigNum.One, new List<BigFraction>() { new BigFraction(new BigNum("1")), new BigFraction(new BigNum("0")) })
                    },
                    new object[] {
                        new BigNum("3"),
                        new List<BigFraction>() { new BigFraction(BigNum.One), new BigFraction(new BigNum("2")), new BigFraction(new BigNum("3")), new BigFraction(new BigNum("4")) },
                        new BigNum("2"),
                        new List<BigFraction>() { new BigFraction(new BigNum("2")), new BigFraction(new BigNum("3")), new BigFraction(new BigNum("4")) },
                        new Polynomial(BigNum.One, new List<BigFraction>() { new BigFraction(new BigNum("1"), new BigNum("2")), new BigFraction(new BigNum("1"), new BigNum("4")) })
                    },
                    new object[] {
                        new BigNum("3"),
                        new List<BigFraction>() { new BigFraction(BigNum.One), new BigFraction(new BigNum("2")), new BigFraction(new BigNum("3")), new BigFraction(new BigNum("4")) },
                        new BigNum("3"),
                        new List<BigFraction>() { new BigFraction(new BigNum("1"), new BigNum("2")), new BigFraction(new BigNum("3")), new BigFraction(new BigNum("2")), new BigFraction(BigNum.One) },
                        new Polynomial(BigNum.Zero, new List<BigFraction>() { new BigFraction(new BigNum("2"))} )
                    },
                    new object[] {
                        new BigNum("3"),
                        new List<BigFraction>() { new BigFraction(BigNum.One), new BigFraction(new BigNum("2")), new BigFraction(new BigNum("3")), new BigFraction(new BigNum("4")) },
                        new BigNum("2"),
                        new List<BigFraction>() { new BigFraction(BigNum.One), new BigFraction(new BigNum("2")), new BigFraction(new BigNum("3")) },
                        new Polynomial(BigNum.One, new List<BigFraction>() { new BigFraction(new BigNum("1")), new BigFraction(new BigNum("0")) })
                    },
                    new object[] {
                        new BigNum("3"),
                        new List<BigFraction>() { new BigFraction(BigNum.One), new BigFraction(new BigNum("2")), new BigFraction(new BigNum("3")), new BigFraction(new BigNum("4")) },
                        new BigNum("3"),
                        new List<BigFraction>() { new BigFraction(BigNum.One), new BigFraction(new BigNum("2")), new BigFraction(new BigNum("3")), new BigFraction(new BigNum("4")) },
                        new Polynomial(BigNum.Zero, new List<BigFraction>() { new BigFraction(new BigNum("1"))})
                    },
                    new object[] {
                        new BigNum("3"),
                        new List<BigFraction>() { new BigFraction(BigNum.One), new BigFraction(new BigNum("2")), new BigFraction(new BigNum("3")), new BigFraction(new BigNum("4")) },
                        new BigNum("3"),
                        new List<BigFraction>() { new BigFraction(new BigNum("4")), new BigFraction(new BigNum("3")), new BigFraction(new BigNum("2")), new BigFraction(BigNum.One) },
                        new Polynomial(BigNum.Zero, new List<BigFraction>() { new BigFraction(new BigNum("1"), (new BigNum("4"))) } )
                    },
                    new object[] {
                        new BigNum("4"),
                        new List<BigFraction>() { new BigFraction(new BigNum("7"), (new BigNum("23"))), new BigFraction(new BigNum("5"), (new BigNum("4"))), new BigFraction(new BigNum("7"), (new BigNum("3"))), new BigFraction(new BigNum("3")), new BigFraction(new BigNum("9"), (new BigNum("17"))) },
                        new BigNum("3"),
                        new List<BigFraction>() { new BigFraction(new BigNum("1"), (new BigNum("135"))), new BigFraction(BigNum.Zero), new BigFraction(new BigNum("2"), (new BigNum("3"))), new BigFraction(BigNum.One) },
                        new Polynomial(BigNum.One, new List<BigFraction>() { new BigFraction(new BigNum("945"), (new BigNum("23"))), new BigFraction(new BigNum("675"), (new BigNum("4"))) })
                    },
                    new object[] {
                        new BigNum("2"),
                        new List<BigFraction>() { new BigFraction(BigNum.One), new BigFraction(new BigNum("2")), new BigFraction(new BigNum("3")) },
                        new BigNum("3"),
                        new List<BigFraction>() { new BigFraction(BigNum.One), new BigFraction(new BigNum("2")), new BigFraction(new BigNum("3")), new BigFraction(new BigNum("4")) },
                        new Polynomial(BigNum.Zero, new List<BigFraction>() { new BigFraction(BigNum.Zero) })
                    },
                };
            }
        }
    }
}
