using Xunit;
using BigNumWizardShared;
using System.Collections.Generic;

namespace BigNumWizardTests
{
    public class Test_P8 //Bratsun
    {
        public static void Polumn(int m, List<BigFraction> a, int n,List<BigFraction> b, List<BigFraction> res)
        {
            var actual = P8.MUL_PP_P(a, b);
            Assert.Equal(actual, res);
        }

        public static IEnumerable<object[]> Data
        {
            get
            {
                return new[]
                {
                    new object[] {
                        1,
                        new Polynomial(BigNum.One, new List<BigFraction>() { new BigFraction(new BigNum("3")), new BigFraction(new BigNum("15")) }),
                        2,
                        new Polynomial(new BigNum("2"), new List<BigFraction>() { new BigFraction(new BigNum("20")), new BigFraction(new BigNum("11111")), new BigFraction(new BigNum("9")) }),
                        new Polynomial(new BigNum("3"), new List<BigFraction>() { new BigFraction(new BigNum("60")), new BigFraction(new BigNum("33633")), new BigFraction(new BigNum("166692")), new BigFraction(new BigNum("135")) }) },
                    new object[] {
                        3,
                        new Polynomial(new BigNum("3"), new List<BigFraction>() { new BigFraction(new BigNum("234555"), new BigNum("4")), new BigFraction(new BigNum("-15850980")), new BigFraction(new BigNum("-16406505"), new BigNum("214244")), new BigFraction(new BigNum("-13716665295"), new BigNum("10")) }),
                        0,
                        new Polynomial(BigNum.Zero, new List<BigFraction>(){ new BigFraction(new BigNum("-100018240127467456841003024872985079366"), new BigNum("1373136153549541768244")) }),
                        new Polynomial(new BigNum("3"), new List<BigFraction>() { new BigFraction(new BigNum("-11729889156549064669670732249541507645346065"), new BigNum("2746272307099083536488")), new BigFraction(new BigNum("396346780973921027259400531800297258332219670"), new BigNum("343284038387385442061")), new BigFraction(new BigNum("820474878371247733999600166296877034771837915"), new BigNum ("147093091040534013297833768")), new BigFraction (new BigNum ("137191672322340924149289652426529622119243280297"), new BigNum("1373136153549541768244"))})
                    },
                    new object[]
                    {
                        5,
                        new Polynomial(new BigNum("5"), new List<BigFraction>() { new BigFraction(new BigNum("-123456789098765431234567890"), new BigNum("1000000000")), new BigFraction(BigNum.Zero), new BigFraction(BigNum.Zero), new BigFraction(BigNum.Zero), new BigFraction(BigNum.Zero), new BigFraction(new BigNum("123456789098765431234567890")) }),
                        1,
                        new Polynomial(BigNum.One, new List<BigFraction>(){ new BigFraction(BigNum.Zero), new BigFraction(BigNum.One) }),
                        new Polynomial(new BigNum("5"), new List<BigFraction>() { new BigFraction(new BigNum("-123456789098765431234567890"), new BigNum("1000000000")), new BigFraction(BigNum.Zero), new BigFraction(BigNum.Zero), new BigFraction(BigNum.Zero), new BigFraction(BigNum.Zero), new BigFraction(new BigNum("123456789098765431234567890")) })
                    },
                    new object[]
                    {
                        4,
                        new Polynomial(new BigNum("4"), new List<BigFraction>(){ new BigFraction(new BigNum("381219492892820")), new BigFraction(new BigNum("-5")), new BigFraction(BigNum.Zero), new BigFraction(new BigNum("5000000000000000000")), new BigFraction(new BigNum("5")) }),
                        0,
                        new Polynomial(BigNum.Zero, new List<BigFraction>(){ new BigFraction(new BigNum("3333000"), new BigNum("94000")) }),
                        new Polynomial(new BigNum("4"), new List<BigFraction>(){ new BigFraction(new BigNum("635302284905884530"), new BigNum("47")), new BigFraction(new BigNum("-16665"), new BigNum("94")), new BigFraction(BigNum.Zero), new BigFraction(new BigNum("8332500000000000000000"), new BigNum ("47")), new BigFraction(new BigNum("16665"), new BigNum ("94")) })
                    },
                    new object[]
                    {
                        1,
                        new Polynomial(BigNum.One, new List<BigFraction>() { new BigFraction(new BigNum("-77777777777777777777777777777770"), BigNum.MinusOne), new BigFraction(new BigNum("-1999999999999999999999990"), new BigNum("666666"))}),
                        3,
                        new Polynomial(new BigNum("3"), new List<BigFraction>(){ new BigFraction(new BigNum("12345"), new BigNum("-11111111117")), new BigFraction(new BigNum("-5776072822652739171128927333555000000000000000152394910"), new BigNum("1366666667391")), new BigFraction(new BigNum("548666666666666666666666666666661180"), new BigNum("-11111111117")), new BigFraction(new BigNum("123450"), new BigNum("-11111111117")) }),
                        new Polynomial(new BigNum("4"), new List<BigFraction>() { new BigFraction(new BigNum("960166666666666666666666666666570650"), new BigNum("11111111117")), new BigFraction(new BigNum("-16638876265868072275196828572999844390151190970989255339050366347123888888888844989165319475"), new BigNum("50617233360160467")), new BigFraction(new BigNum("274967770826920912910899926342423187084001236643606054047619047618964266797050"), new BigNum("21693100011497343")), new BigFraction(new BigNum("16626262626262626165639744494949328686868686868696567331200"), new BigNum("112233333392817")), new BigFraction(new BigNum("41149999999999999999999794250"), new BigNum("1234566667320987"))})
                    },
                };
            }
        }

    }
}
