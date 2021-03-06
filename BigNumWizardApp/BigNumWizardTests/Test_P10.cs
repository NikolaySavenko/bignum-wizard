using Xunit;
using BigNumWizardShared;
using System.Collections.Generic;

namespace BigNumWizardTests
{
    public class Test_P10 //Shvets
    {
        [Theory, MemberData(nameof(Data))]

        public static void RemainderPolynomial(BigNum m1, List<BigFraction> C1, BigNum m2, List<BigFraction> C2, Polynomial result)
        {
            Polynomial remainder = P10.MOD_PP_P(m1, C1, m2, C2);
            Assert.Equal(result, remainder);
        }
        public static IEnumerable<object[]> Data
        {
            get
            {
                return new[]
                {
                    new object[] {
                        BigNum.One,
                        new List<BigFraction>() { new BigFraction(new BigNum("2")), new BigFraction(new BigNum("2")) },
                        BigNum.One,
                        new List<BigFraction>() { new BigFraction(new BigNum("2")), new BigFraction(BigNum.One) },
                        new Polynomial(BigNum.Zero, new List<BigFraction>() { new BigFraction(BigNum.One) })
                    },
                    new object[] {
                        new BigNum("4"),
                        new List<BigFraction>() { new BigFraction(BigNum.One), new BigFraction(new BigNum("2")), new BigFraction(new BigNum("3")), new BigFraction(new BigNum("4")), new BigFraction(new BigNum("5")), },
                        new BigNum("3"),
                        new List<BigFraction>() { new BigFraction(BigNum.One), new BigFraction(new BigNum("2")), new BigFraction(new BigNum("3")), new BigFraction(new BigNum("4")) },
                        new Polynomial(BigNum.Zero, new List<BigFraction>() { new BigFraction(new BigNum("5")) })
                    },
                    new object[] {
                        new BigNum("2"),
                        new List<BigFraction>() { new BigFraction(BigNum.One), new BigFraction(new BigNum("2")), new BigFraction(new BigNum("3")) },
                        new BigNum("3"),
                        new List<BigFraction>() { new BigFraction(BigNum.One), new BigFraction(new BigNum("2")), new BigFraction(new BigNum("3")), new BigFraction(new BigNum("4")) },
                        new Polynomial(new BigNum("2"), new List<BigFraction>() { new BigFraction(BigNum.One), new BigFraction(new BigNum("2")), new BigFraction(new BigNum("3")) })
                    },
                    new object[] {
                        new BigNum("3"),
                        new List<BigFraction>() { new BigFraction(BigNum.One), new BigFraction(new BigNum("2")), new BigFraction(new BigNum("3")), new BigFraction(new BigNum("4")) },
                        new BigNum("3"),
                        new List<BigFraction>() { new BigFraction(BigNum.One), new BigFraction(new BigNum("2")), new BigFraction(new BigNum("3")), new BigFraction(new BigNum("4")) },
                        new Polynomial(BigNum.Zero, new List<BigFraction>() { new BigFraction(BigNum.Zero) } )
                    },
                    new object[] {
                        new BigNum("2"),
                        new List<BigFraction>() { new BigFraction(new BigNum("6")), new BigFraction(new BigNum("3")), new BigFraction(new BigNum("2")) },
                        new BigNum("2"),
                        new List<BigFraction>() { new BigFraction(new BigNum("6")), new BigFraction(new BigNum("3")), new BigFraction(new BigNum("1")) },
                        new Polynomial(BigNum.Zero, new List<BigFraction>() { new BigFraction(BigNum.One)} )
                    },
                    new object[] {
                        new BigNum("6"),
                        new List<BigFraction>() { new BigFraction(new BigNum("2")), new BigFraction(BigNum.Zero), new BigFraction(BigNum.Zero), new BigFraction(new BigNum("7"), new BigNum("9")), new BigFraction(new BigNum("12"), new BigNum("11")), new BigFraction(BigNum.Zero), new BigFraction(BigNum.One)},
                        new BigNum("5"),
                        new List<BigFraction>() { new BigFraction(new BigNum("3")), new BigFraction(BigNum.One, new BigNum("8")), new BigFraction(BigNum.Zero), new BigFraction(BigNum.Zero), new BigFraction(BigNum.Zero),  new BigFraction(new BigNum("8"), new BigNum("11"))},
                        new Polynomial(new BigNum("4"), new List<BigFraction>() { new BigFraction(BigNum.One, new BigNum("288")), new BigFraction(new BigNum("7"), new BigNum("9")), new BigFraction(new BigNum("12"), new BigNum("11")), new BigFraction(new BigNum("-16"), new BigNum("33")), new BigFraction(new BigNum("101"), new BigNum("99")) } )
                    },
                    new object[] {
                        new BigNum("3"),
                        new List<BigFraction>() { new BigFraction(new BigNum("124")), new BigFraction(new BigNum("7"), new BigNum("9")), new BigFraction(BigNum.Zero),  new BigFraction(new BigNum("12"))},
                        new BigNum("2"),
                        new List<BigFraction>() { new BigFraction(new BigNum("1"), new BigNum("2")), new BigFraction(new BigNum("213")), new BigFraction(BigNum.One) },
                        new Polynomial(BigNum.One, new List<BigFraction>() { new BigFraction(new BigNum("67507334"), new BigNum("3")), new BigFraction(new BigNum("950926"), new BigNum("9")) } )
                    },
                    new object[] {
                        new BigNum("2"),
                        new List<BigFraction>() { new BigFraction(BigNum.One), new BigFraction(new BigNum("24346789")), new BigFraction(new BigNum("6688888888881")) },
                        new BigNum("3"),
                        new List<BigFraction>() { new BigFraction(BigNum.One), new BigFraction(new BigNum("2")), new BigFraction(new BigNum("3")), new BigFraction(new BigNum("668")) },
                        new Polynomial(new BigNum("2"), new List<BigFraction>() { new BigFraction(BigNum.One), new BigFraction(new BigNum("24346789")), new BigFraction(new BigNum("6688888888881")) })
                    },
                    new object[] {
                        new BigNum("3"),
                        new List<BigFraction>() { new BigFraction(new BigNum("122222222")), new BigFraction(new BigNum("122222222")), new BigFraction(BigNum.Zero), new BigFraction(new BigNum("122222222")) },
                        new BigNum("2"),
                        new List<BigFraction>() { new BigFraction(new BigNum("122222222")), new BigFraction(new BigNum("122222222")), new BigFraction(new BigNum("122222222")) },
                        new Polynomial(BigNum.One, new List<BigFraction>() { new BigFraction(new BigNum("-122222222")), new BigFraction(new BigNum("122222222")) } )
                    },
                    new object[] {
                        new BigNum("3"),
                        new List<BigFraction>() { new BigFraction(new BigNum("12")), new BigFraction(new BigNum("-7")), new BigFraction(BigNum.Zero), new BigFraction(new BigNum("8")) },
                        new BigNum("2"),
                        new List<BigFraction>() { new BigFraction(new BigNum("33")), new BigFraction(new BigNum("2")), new BigFraction(new BigNum("-11")) },
                        new Polynomial(BigNum.One , new List<BigFraction>() { new BigFraction(new BigNum("1622"), new BigNum("363")), new BigFraction(new BigNum("179"), new BigNum("33")) } )
                    },
                };
            }
        }
    }
}
