using Xunit;
using BigNumWizardShared;
using System.Collections.Generic;

namespace BigNumWizardTests
{
    public class Test_P11 //Bratsun
    {
        [Theory, MemberData(nameof(Data))]
        public static void Polnod(BigNum m, List<BigFraction> a, BigNum n, List<BigFraction> b, Polynomial res)
        {

            var actual = P11.GCF_PP_P(m, a, n, b);
            Assert.Equal(res, actual);
        }
        public static IEnumerable<object[]> Data
        {
            get
            {
                return new[] //не работают
                {
                     new object[] {
                        new BigNum("2"),
                        new List<BigFraction>() { new BigFraction(new BigNum("45")), new BigFraction(new BigNum("35")), new BigFraction(new BigNum("67")) },
                        new BigNum("2"),
                        new List<BigFraction>() { new BigFraction(new BigNum("34")), new BigFraction(new BigNum("98")), new BigFraction(new BigNum("56")) },
                        new Polynomial(BigNum.One, new List<BigFraction>() { new BigFraction(new BigNum("322"), new BigNum("9")), new BigFraction(new BigNum("121"), new BigNum("45")) }) },
                     new object[] {
                        new BigNum("2"),
                        new List<BigFraction>() { new BigFraction(new BigNum("234555")), new BigFraction(new BigNum("-15850980")), new BigFraction(new BigNum("-16406505"))},
                        new BigNum("3"),
                        new List<BigFraction>(){ new BigFraction(new BigNum("31245")), new BigFraction(new BigNum("-6633")), new BigFraction(new BigNum("271498")), new BigFraction(new BigNum("52632")) },
                        new Polynomial(BigNum.One, new List<BigFraction>() { new BigFraction(new BigNum("52237416325"), new BigNum("361")), new BigFraction(new BigNum("53169103089"), new BigNum("361")) }) },
                     new object[] {
                        new BigNum("3"),
                        new List<BigFraction>(){ new BigFraction(new BigNum("31245")), new BigFraction(new BigNum("-6633")), new BigFraction(new BigNum("271498")), new BigFraction(new BigNum("52632")) },
                        new BigNum("2"),
                        new List<BigFraction>() { new BigFraction(new BigNum("234555")), new BigFraction(new BigNum("-15850980")), new BigFraction(new BigNum("-16406505"))},
                        new Polynomial(BigNum.One, new List<BigFraction>() { new BigFraction(new BigNum("52237416325"), new BigNum("361")), new BigFraction(new BigNum("53169103089"), new BigNum("361")) }) },
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
                        BigNum.One,
                        new List<BigFraction>() { new BigFraction(new BigNum("-77777777777777777777777777777770"), BigNum.MinusOne), new BigFraction(new BigNum("-1999999999999999999999990"), new BigNum("666666"))},
                        new BigNum("3"),
                        new List<BigFraction>(){ new BigFraction(new BigNum("12345"), new BigNum("-11111111117")), new BigFraction(new BigNum("-5776072822652739171128927333555000000000000000152394910"), new BigNum("1366666667391")), new BigFraction(new BigNum("548666666666666666666666666666661180"), new BigNum("-11111111117")), new BigFraction(new BigNum("123450"), new BigNum("-11111111117")) },
                        new Polynomial(BigNum.One, new List<BigFraction>() { new BigFraction(new BigNum("5185179999999999999999999999999481482")), new BigFraction(new BigNum("-199999999999999999999999"))})
                    },
                };
            }
        }
    }
}
