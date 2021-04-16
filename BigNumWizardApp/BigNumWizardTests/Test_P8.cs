using Xunit;
using BigNumWizardShared;
using System.Collections.Generic;

namespace BigNumWizardTests
{
    public class Test_P8 //Bratsun
    {
        [Theory, MemberData(nameof(Data))]
        public static void Polumn(BigNum m, List<BigFraction> a, BigNum n, List<BigFraction> b, Polynomial res)
        {

            var actual = P8.MUL_PP_P(m, a, n, b);
            Assert.Equal(res, actual);
        }

        public static IEnumerable<object[]> Data
        {
            get
            {
                return new[]
                {
                     new object[] {//true
                        new BigNum("2"),
                        new List<BigFraction>() { new BigFraction(new BigNum("45")), new BigFraction(new BigNum("35")), new BigFraction(new BigNum("67")) },
                        new BigNum("2"),
                        new List<BigFraction>() { new BigFraction(new BigNum("34")), new BigFraction(new BigNum("98")), new BigFraction(new BigNum("56")) },
                        new Polynomial(new BigNum("4"), new List<BigFraction>() { new BigFraction(new BigNum("1530")), new BigFraction(new BigNum("5600")), new BigFraction(new BigNum("8228")), new BigFraction(new BigNum("8526")), new BigFraction(new BigNum("3752")) }) },
                     new object[] {//true
                        new BigNum("2"),
                        new List<BigFraction>() { new BigFraction(new BigNum("234555")), new BigFraction(new BigNum("-15850980")), new BigFraction(new BigNum("-16406505"))},
                        new BigNum("3"),
                        new List<BigFraction>(){ new BigFraction(new BigNum("31245")), new BigFraction(new BigNum("-6633")), new BigFraction(new BigNum("271498")), new BigFraction(new BigNum("52632")) },
                        new Polynomial(new BigNum("5"), new List<BigFraction>() { new BigFraction(new BigNum("7328670975")), new BigFraction(new BigNum("-496819673415")), new BigFraction(new BigNum("-343800484995")), new BigFraction (new BigNum ("-4182339921615")), new BigFraction (new BigNum ("-5288602073850")), new BigFraction (new BigNum ("-863507171160"))})
                     },
                     new object[] {//true
                        new BigNum("3"),
                        new List<BigFraction>(){ new BigFraction(new BigNum("31245")), new BigFraction(new BigNum("-6633")), new BigFraction(new BigNum("271498")), new BigFraction(new BigNum("52632")) },

                        new BigNum("2"),
                        new List<BigFraction>() { new BigFraction(new BigNum("234555")), new BigFraction(new BigNum("-15850980")), new BigFraction(new BigNum("-16406505"))},
                        new Polynomial(new BigNum("5"), new List<BigFraction>() { new BigFraction(new BigNum("7328670975")), new BigFraction(new BigNum("-496819673415")), new BigFraction(new BigNum("-343800484995")), new BigFraction (new BigNum ("-4182339921615")), new BigFraction (new BigNum ("-5288602073850")), new BigFraction (new BigNum ("-863507171160"))})
                    },
                    new object[]
                    {//некоторые коэффициенты получились слишком большими. Из-за этого сокращение выдаёт неправильный результат
                        new BigNum("5"),
                        new List<BigFraction>() { new BigFraction(new BigNum("-123456789098765431234567890")), new BigFraction(BigNum.Zero), new BigFraction(BigNum.Zero), new BigFraction(BigNum.Zero), new BigFraction(BigNum.Zero), new BigFraction(new BigNum("123456789098765431234567890")) },
                        BigNum.Zero,
                        new List<BigFraction>(){new BigFraction(BigNum.One)},
                        new Polynomial(new BigNum("5"), new List<BigFraction>() { new BigFraction(new BigNum("-123456789098765431234567890")), new BigFraction(BigNum.Zero), new BigFraction(BigNum.Zero), new BigFraction(BigNum.Zero), new BigFraction(BigNum.Zero), new BigFraction(new BigNum("123456789098765431234567890")) })
                    },
                    new object[]
                    {//некоторые коэффициенты получились слишком большими. Из-за этого сокращение выдаёт неправильный результат
                        new BigNum("5"),
                        new List<BigFraction>() { new BigFraction(new BigNum("-123456789098765431234567890"), new BigNum("1000000000")), new BigFraction(BigNum.Zero), new BigFraction(BigNum.Zero), new BigFraction(BigNum.Zero), new BigFraction(BigNum.Zero), new BigFraction(new BigNum("123456789098765431234567890")) },
                        BigNum.Zero,
                        new List<BigFraction>(){new BigFraction(BigNum.One)},
                        new Polynomial(new BigNum("5"), new List<BigFraction>() { new BigFraction(new BigNum("-123456789098765431234567890"), new BigNum("1000000000")), new BigFraction(BigNum.Zero), new BigFraction(BigNum.Zero), new BigFraction(BigNum.Zero), new BigFraction(BigNum.Zero), new BigFraction(new BigNum("123456789098765431234567890")) })
                    },
                    new object[]
                    {//true
                        new BigNum("4"),
                        new List<BigFraction>(){ new BigFraction(new BigNum("381219")), new BigFraction(new BigNum("-5")), new BigFraction(BigNum.Zero), new BigFraction(new BigNum("4221")), new BigFraction(new BigNum("5")) },
                        BigNum.Zero,
                        new List<BigFraction>(){ new BigFraction(new BigNum("3333000"), new BigNum("94000")) },
                        new Polynomial(new BigNum("4"), new List<BigFraction>(){ new BigFraction(new BigNum("1270602927"), new BigNum("94")), new BigFraction(new BigNum("-16665"), new BigNum("94")), new BigFraction(BigNum.Zero), new BigFraction(new BigNum("14068593"), new BigNum ("94")), new BigFraction(new BigNum("16665"), new BigNum ("94")) })
                    },
                    new object[]
                    {//некоторые коэффициенты получились слишком большими. Из-за этого сокращение выдаёт неправильный результат
                        BigNum.One,
                        new List<BigFraction>() { new BigFraction(new BigNum("-77777777777777777777777777777770"), BigNum.MinusOne), new BigFraction(new BigNum("-1999999999999999999999990"), new BigNum("666666"))},
                        new BigNum("3"),
                        new List<BigFraction>(){ new BigFraction(new BigNum("12345"), new BigNum("-11111111117")), new BigFraction(new BigNum("-5776072822652739171128927333555000000000000000152394910"), new BigNum("1366666667391")), new BigFraction(new BigNum("548666666666666666666666666666661180"), new BigNum("-11111111117")), new BigFraction(new BigNum("123450"), new BigNum("-11111111117")) },
                        new Polynomial(new BigNum("4"), new List<BigFraction>() { new BigFraction(new BigNum("960166666666666666666666666666570650"), new BigNum("11111111117")), new BigFraction(new BigNum("-16638876265868072275196828572999844390151190970989255339050366347123888888888844989165319475"), new BigNum("50617233360160467")), new BigFraction(new BigNum("274967770826920912910899926342423187084001236643606054047619047618964266797050"), new BigNum("21693100011497343")), new BigFraction(new BigNum("16626262626262626165639744494949328686868686868696567331200"), new BigNum("112233333392817")), new BigFraction(new BigNum("41149999999999999999999794250"), new BigNum("1234566667320987"))})
                    },
                    new object[]
                    {//некоторые коэффициенты получились слишком большими. Из-за этого сокращение выдаёт неправильный результат
                        BigNum.One,
                        new List<BigFraction>() { new BigFraction(new BigNum("214545"), new BigNum("6723")), new BigFraction(new BigNum("-1577812"), new BigNum("62376325"))},
                        new BigNum("3"),
                        new List<BigFraction>(){ new BigFraction(new BigNum("12345"), new BigNum("-21347")), new BigFraction(new BigNum("-215562326"), new BigNum("6673")), new BigFraction(new BigNum("54866"), new BigNum("-1117")), new BigFraction(new BigNum("123450"), new BigNum("-1117")) },
                        new Polynomial(new BigNum("4"), new List<BigFraction>() { new BigFraction(new BigNum("-294284225"), new BigNum("15946209")), new BigFraction(new BigNum("-4105410868789020422352146"), new BigNum("3982443390885087315")), new BigFraction(new BigNum("-781828029799232636486"), new BigNum("1041923752194369825")), new BigFraction(new BigNum("-183499018139536826"), new BigNum("52046743203675")), new BigFraction(new BigNum("7791235656"), new BigNum("2786974201"))})
                    },
                };
            }
        }

    }
}
