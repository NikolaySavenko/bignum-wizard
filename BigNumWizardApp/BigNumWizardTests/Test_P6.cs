using Xunit;
using BigNumWizardShared;
using System.Collections.Generic;

namespace BigNumWizardTests
{
    public class Test_P6 //Petrakova
    {
        [Theory, MemberData(nameof(Data))]

        public static void SeniorDegree(int m, List<BigFraction> c, int res)
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
                    new object[] { 1, new List<BigFraction>() { new BigFraction(BigNum.One), new BigFraction(new BigNum("2")) }, 1 },
                    new object[] { 6, new List<BigFraction>() { new BigFraction(new BigNum("-5574534")), new BigFraction(new BigNum("1775999999999999999")), new BigFraction(new BigNum("-9888436748888888888888734373738")), new BigFraction(new BigNum("976")), new BigFraction(new BigNum("180")), new BigFraction(new BigNum("432")), new BigFraction(BigNum.Zero) }, 6},
                    new object[] { 5, new List<BigFraction>() { new BigFraction(new BigNum("4543")), new BigFraction(new BigNum("21")), new BigFraction(new BigNum("1111")), new BigFraction(new BigNum("5448")), new BigFraction(new BigNum("84623423333333333")), new BigFraction(new BigNum("2342")) }, 5},
                    new object[] { 0, new List<BigFraction>() { new BigFraction(new BigNum("126545")) }, 0},
                    new object[] { 8, new List<BigFraction>() { new BigFraction(BigNum.Zero), new BigFraction(new BigNum("12")), new BigFraction(new BigNum("83000000000000000000000002")), new BigFraction(BigNum.Zero), new BigFraction(BigNum.Zero), new BigFraction(new BigNum("12274246")), new BigFraction(BigNum.Zero), new BigFraction(new BigNum("900")), new BigFraction(new BigNum("126")) }, 8},
                    new object[] { 2, new List<BigFraction>() { new BigFraction(BigNum.Zero), new BigFraction(BigNum.Zero), new BigFraction(new BigNum("-99132")) }, 2}
                };
            }
        }

    }
}

