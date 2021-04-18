using BigNumWizardShared;
using System.Collections.Generic;
using Xunit;

namespace BigNumWizardTests
{
    public class Test_P1
    {
        [Theory, MemberData(nameof(Data))]

        public static void MultiplyPolynomOnQ(BigNum m1, List<BigFraction> c1, BigNum m2, List<BigFraction> c2, Polynomial res)
        {
            var actualPolynom = P1_2.ADD_PP_P(m1, c1, m2, c2);

            Assert.Equal(res, actualPolynom);
        }

        public static IEnumerable<object[]> Data
        {
            get
            {
                return new[]
                {
                    
                    new object[] {
                        BigNum.One,
                        new List<BigFraction>() { new BigFraction(new BigNum("5"), new BigNum("149")), new BigFraction(new BigNum("8"), new BigNum("973")) },
                        BigNum.One,
                        new List<BigFraction>() { new BigFraction(BigNum.One, new BigNum("308")), new BigFraction(new BigNum("5"), new BigNum("441")) },
                        new Polynomial(BigNum.One, new List<BigFraction>() { new BigFraction(new BigNum("1689"), new BigNum("45892")), new BigFraction(new BigNum("1199"), new BigNum("61299")) })
                    },
                    new object[] {
                       new BigNum("8"),
                       new List<BigFraction>() { new BigFraction(new BigNum("-32525"), new BigNum("23423")),new BigFraction(new BigNum("12312424"), new BigNum("534523")),new BigFraction(new BigNum("0"), new BigNum("2342424")),new BigFraction(new BigNum("0"), new BigNum("131231")),new BigFraction(new BigNum("-12313"), new BigNum("52424")),new BigFraction(new BigNum("5235235"), new BigNum("2342")),new BigFraction(new BigNum("123123"), new BigNum("5345645")),new BigFraction(new BigNum("2423455"), new BigNum("6345342")),new BigFraction(new BigNum("-234255"), new BigNum("52563")), },
                       new BigNum("4"),
                       new List<BigFraction>() { new BigFraction(new BigNum("978979"), new BigNum("4646")),new BigFraction(new BigNum("353455"), new BigNum("76543")),new BigFraction(new BigNum("234324"), new BigNum("7655")),new BigFraction(new BigNum("457566765"), new BigNum("3453453")),new BigFraction(new BigNum("-2342345"), new BigNum("745645")), },
                       new Polynomial(new BigNum("8"),new List<BigFraction>(){new BigFraction(new BigNum("-32525"), new BigNum("23423")),new BigFraction(new BigNum("12312424"), new BigNum("534523")),new BigFraction(new BigNum("0"), new BigNum("2342424")),new BigFraction(new BigNum("0"), new BigNum("131231")),new BigFraction(new BigNum("25632394449"), new BigNum("121780952")),new BigFraction(new BigNum("401548384215"), new BigNum("179263706")),new BigFraction(new BigNum("250711085109"), new BigNum("8184182495")),new BigFraction(new BigNum("323531877744305"), new BigNum("2434815596214")),new BigFraction(new BigNum("-2836111902"), new BigNum("373269887")),})
                    },
                    new object[] {
                        new BigNum("3"),
                        new List<BigFraction>() { new BigFraction(new BigNum("53345"), new BigNum("24")),new BigFraction(new BigNum("123"), new BigNum("5345")),new BigFraction(new BigNum("13212"), new BigNum("5353")),new BigFraction(new BigNum("-3123"), new BigNum("5345")), },
                        new BigNum("3"),
                        new List<BigFraction>() { new BigFraction(new BigNum("123"), new BigNum("4235")),new BigFraction(new BigNum("24"), new BigNum("5345")),new BigFraction(new BigNum("2345"), new BigNum("1234")),new BigFraction(new BigNum("535"), new BigNum("234")), },
                        new Polynomial(new BigNum("3"),new List<BigFraction>(){new BigFraction(new BigNum("225919027"), new BigNum("101640")),new BigFraction(new BigNum("147"), new BigNum("5345")),new BigFraction(new BigNum("28856393"), new BigNum("6605602")),new BigFraction(new BigNum("2128793"), new BigNum("1250730")),})
                    },
                    new object[] {
                        new BigNum("1"),
                        new List<BigFraction>() { new BigFraction(new BigNum("32"), new BigNum("1")),new BigFraction(new BigNum("12"), new BigNum("1")), },
                        new BigNum("0"),
                        new List<BigFraction>() { new BigFraction(new BigNum("-6"), new BigNum("1")), },
                        new Polynomial(new BigNum("1"),new List<BigFraction>(){new BigFraction(new BigNum("32"), new BigNum("1")),new BigFraction(new BigNum("6"), new BigNum("1")),})
                    },
                     new object[] {
                         new BigNum("7"),
                         new List<BigFraction>() { new BigFraction(new BigNum("5345"), new BigNum("234")),new BigFraction(new BigNum("345"), new BigNum("3463")),new BigFraction(new BigNum("6456"), new BigNum("234")),new BigFraction(new BigNum("234"), new BigNum("654")),new BigFraction(new BigNum("234"), new BigNum("645")),new BigFraction(new BigNum("23432536"), new BigNum("6456")),new BigFraction(new BigNum("23432"), new BigNum("645645")),new BigFraction(new BigNum("234"), new BigNum("645")), },
                         new BigNum("7"),
                         new List<BigFraction>() { new BigFraction(new BigNum("6456"), new BigNum("234")),new BigFraction(new BigNum("1231231356"), new BigNum("5354")),new BigFraction(new BigNum("243566"), new BigNum("3456")),new BigFraction(new BigNum("4564567"), new BigNum("34535")),new BigFraction(new BigNum("645645"), new BigNum("233423")),new BigFraction(new BigNum("436456"), new BigNum("4536")),new BigFraction(new BigNum("756765"), new BigNum("35345")),new BigFraction(new BigNum("756675"), new BigNum("356")), },
                         new Polynomial(new BigNum("7"),new List<BigFraction>(){new BigFraction(new BigNum("11801"), new BigNum("234")),new BigFraction(new BigNum("2131878016479"), new BigNum("9270451")),new BigFraction(new BigNum("2202955"), new BigNum("22464")),new BigFraction(new BigNum("498884668"), new BigNum("3764315")),new BigFraction(new BigNum("157020669"), new BigNum("50185945")),new BigFraction(new BigNum("568269496"), new BigNum("152523")),new BigFraction(new BigNum("97885948493"), new BigNum("4564064505")),new BigFraction(new BigNum("162712893"), new BigNum("76540")),})
                    },
                     new object[] {
                         new BigNum("12"),
                         new List<BigFraction>() { new BigFraction(new BigNum("12"), new BigNum("4234")),new BigFraction(new BigNum("123"), new BigNum("423")),new BigFraction(new BigNum("345645"), new BigNum("1324")),new BigFraction(new BigNum("135"), new BigNum("635")),new BigFraction(new BigNum("24243"), new BigNum("654")),new BigFraction(new BigNum("1231"), new BigNum("5345")),new BigFraction(new BigNum("1234"), new BigNum("653")),new BigFraction(new BigNum("-234"), new BigNum("536346")),new BigFraction(new BigNum("235"), new BigNum("645")),new BigFraction(new BigNum("3245"), new BigNum("234")),new BigFraction(new BigNum("6456"), new BigNum("765")),new BigFraction(new BigNum("2421"), new BigNum("7657")),new BigFraction(new BigNum("7564"), new BigNum("234")), },
                         new BigNum("12"),
                         new List<BigFraction>() { new BigFraction(new BigNum("32"), new BigNum("24")),new BigFraction(new BigNum("6456"), new BigNum("54")),new BigFraction(new BigNum("-435"), new BigNum("234")),new BigFraction(new BigNum("13"), new BigNum("53")),new BigFraction(new BigNum("6456"), new BigNum("234")),new BigFraction(new BigNum("654"), new BigNum("123")),new BigFraction(new BigNum("6456"), new BigNum("25")),new BigFraction(new BigNum("244"), new BigNum("645")),new BigFraction(new BigNum("64"), new BigNum("1242")),new BigFraction(new BigNum("634"), new BigNum("123")),new BigFraction(new BigNum("6456"), new BigNum("756")),new BigFraction(new BigNum("234"), new BigNum("123")),new BigFraction(new BigNum("6456"), new BigNum("234")), },
                         new Polynomial(new BigNum("12"),new List<BigFraction>(){new BigFraction(new BigNum("8486"), new BigNum("6351")),new BigFraction(new BigNum("50695"), new BigNum("423")),new BigFraction(new BigNum("13384165"), new BigNum("51636")),new BigFraction(new BigNum("3082"), new BigNum("6731")),new BigFraction(new BigNum("549727"), new BigNum("8502")),new BigFraction(new BigNum("1215681"), new BigNum("219145")),new BigFraction(new BigNum("4246618"), new BigNum("16325")),new BigFraction(new BigNum("7262083"), new BigNum("19219065")),new BigFraction(new BigNum("11105"), new BigNum("26703")),new BigFraction(new BigNum("182497"), new BigNum("9594")),new BigFraction(new BigNum("90922"), new BigNum("5355")),new BigFraction(new BigNum("696507"), new BigNum("313937")),new BigFraction(new BigNum("7010"), new BigNum("117")),})
                    },
                       new object[] {
                           new BigNum("9"),
                           new List<BigFraction>() { new BigFraction(new BigNum("6447575"), new BigNum("34521633")),new BigFraction(new BigNum("568867"), new BigNum("34534534")),new BigFraction(new BigNum("2342335"), new BigNum("745754")),new BigFraction(new BigNum("-2543546"), new BigNum("7568967")),new BigFraction(new BigNum("0"), new BigNum("354536")),new BigFraction(new BigNum("0"), new BigNum("636363")),new BigFraction(new BigNum("366456"), new BigNum("242635")),new BigFraction(new BigNum("12123"), new BigNum("645645")),new BigFraction(new BigNum("675"), new BigNum("34535")),new BigFraction(new BigNum("-3535"), new BigNum("6456")), },
                           new BigNum("10"),
                           new List<BigFraction>() { new BigFraction(new BigNum("565756"), new BigNum("2423445")),new BigFraction(new BigNum("6556"), new BigNum("34535")),new BigFraction(new BigNum("24242"), new BigNum("45654")),new BigFraction(new BigNum("756765"), new BigNum("34536")),new BigFraction(new BigNum("-4353"), new BigNum("65332")),new BigFraction(new BigNum("-56547"), new BigNum("34536")),new BigFraction(new BigNum("456464"), new BigNum("745445")),new BigFraction(new BigNum("23424"), new BigNum("45645")),new BigFraction(new BigNum("0"), new BigNum("234234")),new BigFraction(new BigNum("645"), new BigNum("234")),new BigFraction(new BigNum("66453"), new BigNum("34521")), },
                           new Polynomial(new BigNum("10"),new List<BigFraction>(){new BigFraction(new BigNum("565756"), new BigNum("2423445")),new BigFraction(new BigNum("448990828573"), new BigNum("1192204595655")),new BigFraction(new BigNum("431578613623"), new BigNum("788319807618")),new BigFraction(new BigNum("107542567895"), new BigNum("4292560024")),new BigFraction(new BigNum("-199122660623"), new BigNum("494495752044")),new BigFraction(new BigNum("-18849"), new BigNum("11512")),new BigFraction(new BigNum("456464"), new BigNum("745445")),new BigFraction(new BigNum("1494024424"), new BigNum("738338305")),new BigFraction(new BigNum("4041"), new BigNum("215215")),new BigFraction(new BigNum("1495535"), new BigNum("538746")),new BigFraction(new BigNum("102329611"), new BigNum("74289192")),})
                    },
                       new object[] {
                           new BigNum("6"),
                           new List<BigFraction>() { new BigFraction(new BigNum("636"), new BigNum("6747")),new BigFraction(new BigNum("23413"), new BigNum("12314")),new BigFraction(new BigNum("-63453"), new BigNum("756")),new BigFraction(new BigNum("0"), new BigNum("12313245")),new BigFraction(new BigNum("435345"), new BigNum("123425")),new BigFraction(new BigNum("-2345"), new BigNum("63452342")),new BigFraction(new BigNum("34535"), new BigNum("123")), },
                           new BigNum("6"),
                           new List<BigFraction>() { new BigFraction(new BigNum("0"), new BigNum("23525")),new BigFraction(new BigNum("-2342355"), new BigNum("334635")),new BigFraction(new BigNum("0"), new BigNum("1234")),new BigFraction(new BigNum("-345345"), new BigNum("2342")),new BigFraction(new BigNum("6346345"), new BigNum("4535")),new BigFraction(new BigNum("35263"), new BigNum("757")),new BigFraction(new BigNum("98976"), new BigNum("356445")), },
                           new Polynomial(new BigNum("6"),new List<BigFraction>(){new BigFraction(new BigNum("212"), new BigNum("2249")),new BigFraction(new BigNum("-1400596681"), new BigNum("274713026")),new BigFraction(new BigNum("-21151"), new BigNum("252")),new BigFraction(new BigNum("-345345"), new BigNum("2342")),new BigFraction(new BigNum("31410876848"), new BigNum("22389295")),new BigFraction(new BigNum("2237518160781"), new BigNum("48033422894")),new BigFraction(new BigNum("456370449"), new BigNum("1623805")),})
                    },
                       new object[] {
                           new BigNum("4"),
                           new List<BigFraction>() { new BigFraction(new BigNum("64564"), new BigNum("64634")),new BigFraction(new BigNum("2423342"), new BigNum("13215")),new BigFraction(new BigNum("45737367736345"), new BigNum("24234633563")),new BigFraction(new BigNum("46746"), new BigNum("2342411")),new BigFraction(new BigNum("35345"), new BigNum("745463")), },
                           new BigNum("4"),
                           new List<BigFraction>() { new BigFraction(new BigNum("-353364"), new BigNum("242")),new BigFraction(new BigNum("645654"), new BigNum("24235")),new BigFraction(new BigNum("756788"), new BigNum("2342554")),new BigFraction(new BigNum("865745"), new BigNum("353645")),new BigFraction(new BigNum("0"), new BigNum("6456455635")), },
                           new Polynomial(new BigNum("4"),new List<BigFraction>(){new BigFraction(new BigNum("-518720552"), new BigNum("355487")),new BigFraction(new BigNum("13452402196"), new BigNum("64053105")),new BigFraction(new BigNum("53580297110055400387"), new BigNum("28385468895769951")),new BigFraction(new BigNum("408892420073"), new BigNum("165676387619")),new BigFraction(new BigNum("35345"), new BigNum("745463")),})
                    },
                       new object[] {
                           new BigNum("4"),
                           new List<BigFraction>() { new BigFraction(new BigNum("74645"), new BigNum("2411")),new BigFraction(new BigNum("-1234"), new BigNum("5352")),new BigFraction(new BigNum("-645653"), new BigNum("1234")),new BigFraction(new BigNum("0"), new BigNum("64674")),new BigFraction(new BigNum("23478"), new BigNum("12231")), },
                           new BigNum("3"),
                           new List<BigFraction>() { new BigFraction(new BigNum("145"), new BigNum("6563")),new BigFraction(new BigNum("-6464"), new BigNum("123425")),new BigFraction(new BigNum("12314"), new BigNum("64568")),new BigFraction(new BigNum("3242356"), new BigNum("74533")), },
                           new Polynomial(new BigNum("4"),new List<BigFraction>(){new BigFraction(new BigNum("74645"), new BigNum("2411")),new BigFraction(new BigNum("-3661351"), new BigNum("17562588")),new BigFraction(new BigNum("-79697698101"), new BigNum("152306450")),new BigFraction(new BigNum("6157"), new BigNum("32284")),new BigFraction(new BigNum("13802380670"), new BigNum("303871041")),})
                       },
                };
            }
        }
    }
}
