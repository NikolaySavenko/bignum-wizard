using Xunit;
using BigNumWizardShared;
using System.Collections.Generic;

namespace BigNumWizardTests
{
    public class Test_P6 //Petrakova
    {
        [Theory, MemberData(nameof(Data))]

        public static void SeniorDegree(BigNum m, List<BigFraction> c, BigNum res)
        {
            var actual = P_6.DEG_P_N(m, c);
            Assert.Equal(actual, res);
        }

        public static IEnumerable<object[]> Data
        {
            get
            {
                return new[]
                {
                    new object[] { BigNum.One, new List<BigFraction>() { new BigFraction(BigNum.One), new BigFraction(new BigNum("2")) }, BigNum.One },
                    new object[] { new BigNum("6"), new List<BigFraction>() { new BigFraction(new BigNum("-5574534")), new BigFraction(new BigNum("1775999999999999999")), new BigFraction(new BigNum("-9888436748888888888888734373738")), new BigFraction(new BigNum("976")), new BigFraction(new BigNum("180")), new BigFraction(new BigNum("432")), new BigFraction(BigNum.Zero) }, new BigNum("6")},
                    new object[] { new BigNum("5"), new List<BigFraction>() { new BigFraction(new BigNum("4543")), new BigFraction(new BigNum("21")), new BigFraction(new BigNum("1111")), new BigFraction(new BigNum("5448")), new BigFraction(new BigNum("84623423333333333")), new BigFraction(new BigNum("2342")) }, new BigNum("5")},
                    new object[] { new BigNum("0"), new List<BigFraction>() { new BigFraction(new BigNum("126545")) }, new BigNum("0")},
                    new object[] { new BigNum("8"), new List<BigFraction>() { new BigFraction(BigNum.Zero), new BigFraction(new BigNum("12")), new BigFraction(new BigNum("83000000000000000000000002")), new BigFraction(BigNum.Zero), new BigFraction(BigNum.Zero), new BigFraction(new BigNum("12274246")), new BigFraction(BigNum.Zero), new BigFraction(new BigNum("900")), new BigFraction(new BigNum("126")) }, new BigNum("8")},
                    new object[] { new BigNum("2"), new List<BigFraction>() { new BigFraction(BigNum.Zero), new BigFraction(BigNum.Zero), new BigFraction(new BigNum("-99132")) }, new BigNum("2") }
                };
            }
        }

    }
}

