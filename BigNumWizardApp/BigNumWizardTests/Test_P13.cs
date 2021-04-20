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
                    }
                };
            }
        }
    }
    

}
