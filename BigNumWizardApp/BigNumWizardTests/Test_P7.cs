using Xunit;
using BigNumWizardShared;
using System.Collections.Generic;

namespace BigNumWizardTests
{
    public class Test_P7    // Osiptsov
    {
        [Theory, MemberData(nameof(Data))]

        public static void TakingOut(BigNum input_seniorDegree, List<BigFraction> input_members, string res_nom, string res_denom)
        {
            var result = new BigFraction(new BigNum(res_nom), new BigNum(res_denom));

            Assert.Equal(result, P7.FAC_P_Q(input_seniorDegree, input_members));
        }

        public static IEnumerable<object[]> Data
        {
            get
            {
                return new[]
                {
                    new object[] {new BigNum("2"), new List<BigFraction> {new BigFraction(new BigNum("625"), new BigNum("1024")), new BigFraction(new BigNum("25"), new BigNum("8")), new BigFraction(new BigNum("125"), new BigNum("128"))}, "25", "1024"},
                    new object[] {new BigNum("3"), new List<BigFraction> {new BigFraction(new BigNum("1025"), new BigNum("783")), new BigFraction(new BigNum("780"), new BigNum("23445")), new BigFraction(new BigNum("23455435"), new BigNum("123")), new BigFraction(new BigNum("56766575"), new BigNum("47"))}, "5", "3930530805"},
                    new object[] {BigNum.Zero, new List<BigFraction> {new BigFraction(new BigNum("887555888765"), new BigNum("33345654"))}, "887555888765", "33345654"},
                    new object[] {BigNum.One, new List<BigFraction> {new BigFraction(new BigNum("-7786687"), new BigNum("6554")), new BigFraction(new BigNum("99989"), new BigNum("234245654"))}, "1", "767623008158"},
                    new object[] {new BigNum("6"), new List<BigFraction> {new BigFraction(new BigNum("237820701367422209686422828990"), new BigNum("2")), new BigFraction(new BigNum("-281060828888771702356681525170"), new BigNum("3")), new BigFraction(new BigNum("151340446324723224345905436630"), new BigNum("5")), new BigFraction(new BigNum("1275583761879810033772631537310"), new BigNum("7")), new BigFraction(new BigNum("929662741709014092410561967870"), new BigNum("11")), new BigFraction(new BigNum("-1924185674700052423826511980010"), new BigNum("13")), new BigFraction(new BigNum("670221976580917136389009790790"), new BigNum("17")) }, "21620063760674746335129348090", "510510"},
                    new object[] {new BigNum("5"), new List<BigFraction> {new BigFraction(new BigNum("250324657381418613827633319399"), new BigNum("3453")), new BigFraction(new BigNum("-4118978453276069918436511891929"), new BigNum("234")), new BigFraction(new BigNum("3117679823750395463125978614333"), new BigNum("2345")), new BigFraction(new BigNum("113783935173372097194378781545"), new BigNum("667")), new BigFraction(new BigNum("4118978453276069918436511891929"), new BigNum("543545")), new BigFraction(new BigNum("-6986333619645046767734857186863"), new BigNum("34")) }, "22756787034674419438875756309", "1024"},
                    new object[] {new BigNum("2"), new List<BigFraction> {new BigFraction(new BigNum("1771338"), new BigNum("3453")), new BigFraction(new BigNum("2402706"), new BigNum("234")), new BigFraction(new BigNum("1175046"), new BigNum("2345"))}, "17538", "631588230" }
                };
            }
        }
    }
}