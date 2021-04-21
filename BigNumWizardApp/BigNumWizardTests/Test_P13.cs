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
            Assert.Equal(res, actual);
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
                    new object[] {
                        new BigNum("4"),
                        new List<BigFraction>() { new BigFraction(BigNum.One, new BigNum("16")), new BigFraction(BigNum.MinusOne), new BigFraction(new BigNum("6")), new BigFraction(new BigNum("-16")), new BigFraction(new BigNum("16")) },
                        new Polynomial(BigNum.One, new List<BigFraction>() { new BigFraction(BigNum.One, new BigNum("16")), new BigFraction(BigNum.MinusOne, new BigNum("4")) })
                    },
                     new object[] {
                        BigNum.Zero,
                        new List<BigFraction>() { new BigFraction(new BigNum("-127"), new BigNum("576")) },
                        new Polynomial(BigNum.Zero, new List<BigFraction>() { new BigFraction(new BigNum("-1"), new BigNum("576")) })
                     },
                     new object[] {
                        new BigNum("5"),
                        new List<BigFraction>() { new BigFraction(new BigNum("486"), new BigNum("343")), new BigFraction(new BigNum("243"), new BigNum("343")), new BigFraction(new BigNum("-207"), new BigNum("686")), new BigFraction(new BigNum("-95"), new BigNum("588")), new BigFraction(BigNum.One, new BigNum("63")), new BigFraction(BigNum.One, new BigNum("108")) },
                        new Polynomial(new BigNum("2"), new List<BigFraction>() { new BigFraction(new BigNum("6"), new BigNum("343")), new BigFraction(BigNum.One, new BigNum("1029")), new BigFraction(BigNum.MinusOne, new BigNum("441")) })
                    },
                     new object[] {
                        new BigNum("6"),
                        new List<BigFraction>() { new BigFraction(new BigNum("45"), new BigNum("121")), new BigFraction(new BigNum("-1455"), new BigNum("484")), new BigFraction(new BigNum("15"), new BigNum("44")), new BigFraction(new BigNum("42285"), new BigNum("1936")), new BigFraction(new BigNum("53895"), new BigNum("1936")), new BigFraction(new BigNum("1545"), new BigNum("176")), new BigFraction(new BigNum("-15"), new BigNum("16")) },
                        new Polynomial(new BigNum("3"), new List<BigFraction>() { new BigFraction(new BigNum("3"), new BigNum("242")), new BigFraction(new BigNum("-5"), new BigNum("88")), new BigFraction(new BigNum("-123"), new BigNum("1936")), new BigFraction(new BigNum("1"), new BigNum("176")) })
                    },
                    new object[] {
                        new BigNum("4"),
                        new List<BigFraction>() { new BigFraction(new BigNum("75"), new BigNum("11")), new BigFraction(new BigNum("-865"), new BigNum("44")), new BigFraction(new BigNum("-3875"), new BigNum("44")), new BigFraction(new BigNum("-9905"), new BigNum("176")), new BigFraction(new BigNum("85"), new BigNum("16")) },
                        new Polynomial(new BigNum("4"), new List<BigFraction>() {  new BigFraction(new BigNum("15"), new BigNum("11")),  new BigFraction(new BigNum("-173"), new BigNum("44")),  new BigFraction(new BigNum("-775"), new BigNum("44")),  new BigFraction(new BigNum("-1981"), new BigNum("176")),  new BigFraction(new BigNum("17"), new BigNum("16")) })
                    },
                };
            }
        }
    }


}
