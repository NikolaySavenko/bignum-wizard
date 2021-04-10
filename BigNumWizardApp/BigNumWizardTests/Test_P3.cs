using Xunit;
using BigNumWizardShared;
using System.Collections.Generic;

namespace BigNumWizardTests
{
    public class Test_P3 //Petrakova
    {
        [Theory, MemberData(nameof(Data))]

        public static void MultiplyPolynomOnQ(int m, List<BigFraction> c, BigFraction num, Polynomial res)
        {
            Polynomial mult = P3.MUL_PQ_P(m, c, num); 
            Assert.Equal(res.Odds, mult.Odds);
            Assert.Equal(res.SeniorDegree, mult.SeniorDegree);
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
                        new BigFraction(new BigNum("3")),
                        new Polynomial(BigNum.One, new List<BigFraction>() { new BigFraction(new BigNum("3")), new BigFraction(new BigNum("15")) })
                    },
                    new object[] {
                        2,
                        new List<BigFraction>() { new BigFraction(new BigNum("20")), new BigFraction(new BigNum("11111")), new BigFraction(new BigNum("9"))},
                        new BigFraction(BigNum.One),
                        new Polynomial(new BigNum("2"), new List<BigFraction>() { new BigFraction(new BigNum("20")), new BigFraction(new BigNum("11111")), new BigFraction(new BigNum("9")) }) },
                    new object[] {
                        3,
                        new List<BigFraction>() { new BigFraction(new BigNum("19"), new BigNum("4")), new BigFraction(new BigNum("-1284")), new BigFraction(new BigNum("-1329"), new BigNum("214244")), new BigFraction(new BigNum("1111111"), new BigNum("-10")) },
                        new BigFraction(new BigNum("12345")),
                        new Polynomial(new BigNum("3"), new List<BigFraction>() { new BigFraction(new BigNum("234555"), new BigNum("4")), new BigFraction(new BigNum("-15850980")), new BigFraction(new BigNum("-16406505"), new BigNum("214244")), new BigFraction(new BigNum("-13716665295"), new BigNum("10")) })
                    },
                    new object[]
                    {
                        0,
                        new List<BigFraction>() { new BigFraction(new BigNum("-1000000028347484754783383"), new BigNum("-2372733728387"))},
                        new BigFraction(new BigNum("100018237292202"), new BigNum("-578714812")),
                        new Polynomial(BigNum.Zero, new List<BigFraction>(){ new BigFraction(new BigNum("-100018240127467456841003024872985079366"), new BigNum("1373136153549541768244")) })
                    },
                    new object[]
                    {
                        5,
                        new List<BigFraction>() { new BigFraction(BigNum.One, new BigNum("-1000000000")), new BigFraction(BigNum.Zero), new BigFraction(BigNum.Zero), new BigFraction(BigNum.Zero), new BigFraction(BigNum.Zero), new BigFraction(BigNum.MinusOne) },
                        new BigFraction(new BigNum("123456789098765431234567890")),
                        new Polynomial(new BigNum("5"), new List<BigFraction>() { new BigFraction(new BigNum("-123456789098765431234567890"), new BigNum("1000000000")), new BigFraction(BigNum.Zero), new BigFraction(BigNum.Zero), new BigFraction(BigNum.Zero), new BigFraction(BigNum.Zero), new BigFraction(new BigNum("123456789098765431234567890")) })
                    },
                    new object[]
                    {
                        1,
                        new List<BigFraction>(){ new BigFraction(new BigNum("111111111111111111111111111111111111111111111111111111")), new BigFraction(new BigNum("-999999999999999999999999999999999999999999999999999999999999999999999999999999")) },
                        new BigFraction(BigNum.Zero),
                        new Polynomial(BigNum.One, new List<BigFraction>(){ new BigFraction(BigNum.Zero), new BigFraction(BigNum.Zero) }) 
                    },
                    new object[]
                    {
                        4,
                        new List<BigFraction>() { new BigFraction(new BigNum("-76243898578564")), new BigFraction(BigNum.One), new BigFraction(BigNum.Zero), new BigFraction(new BigNum("-1000000000000000000")), new BigFraction(BigNum.MinusOne)},
                        new BigFraction(new BigNum("-5")),
                        new Polynomial(new BigNum("4"), new List<BigFraction>(){ new BigFraction(new BigNum("381219492892820")), new BigFraction(new BigNum("-5")), new BigFraction(BigNum.Zero), new BigFraction(new BigNum("5000000000000000000")), new BigFraction(new BigNum("5")) })
                    },
                    new object[]
                    {
                        0,
                        new List<BigFraction>() { new BigFraction(new BigNum("3333"), new BigNum("1000")) },
                        new BigFraction(new BigNum("1000"), new BigNum("94")),
                        new Polynomial(BigNum.Zero, new List<BigFraction>(){ new BigFraction(new BigNum("3333000"), new BigNum("94000")) })
                    },
                    new object[]
                    {
                        1,
                        new List<BigFraction>() { new BigFraction(new BigNum("-7777777777777777777777777777777"), BigNum.MinusOne), new BigFraction(new BigNum("199999999999999999999999"), new BigNum("-666666"))},
                        new BigFraction(BigNum.Ten),
                        new Polynomial(BigNum.One, new List<BigFraction>() { new BigFraction(new BigNum("-77777777777777777777777777777770"), BigNum.MinusOne), new BigFraction(new BigNum("-1999999999999999999999990"), new BigNum("666666"))})
                    },
                    new object[]
                    {
                        3,
                        new List<BigFraction>(){ new BigFraction(BigNum.One), new BigFraction(new BigNum("-467887632454656878989787552333333333333333333345678"), new BigNum("-123")), new BigFraction(new BigNum("44444444444444444444444444444444")), new BigFraction(BigNum.Ten)},
                        new BigFraction(new BigNum("12345"), new BigNum("-11111111117")),
                        new Polynomial(new BigNum("3"), new List<BigFraction>(){ new BigFraction(new BigNum("12345"), new BigNum("-11111111117")), new BigFraction(new BigNum("-5776072822652739171128927333555000000000000000152394910"), new BigNum("1366666667391")), new BigFraction(new BigNum("548666666666666666666666666666661180"), new BigNum("-11111111117")), new BigFraction(new BigNum("123450"), new BigNum("-11111111117")) })
                    },
                    new object[]
                    {
                        1,
                        new List<BigFraction>(){ new BigFraction(new BigNum("111111111111111111111111111111111111111111111111111111")), new BigFraction(new BigNum("999999999999999999999999999999999999999999999999999999999999999999999999999999")) },
                        new BigFraction(BigNum.Zero),
                        new Polynomial(BigNum.One, new List<BigFraction>(){ new BigFraction(BigNum.Zero), new BigFraction(BigNum.Zero) })
                    },
                };
            }
        }
    }


}
