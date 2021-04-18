using Xunit;
using BigNumWizardShared;

namespace BigNumWizardTests
{
    public class Test_Z10  //Kabanov
    {
        [Theory]
        [InlineData("100", "2", "0")]//true
        [InlineData("5000", "3000", "2000")]//true
        [InlineData("500000001", "2", "1")]//true
        [InlineData("45", "100", "45")]//true
        [InlineData("-100", "50", "0")]//true
        [InlineData("-100", "55", "10")]//true
        [InlineData("-55", "100", "55")]//true
        [InlineData("150", "-55", "40")]//true
        [InlineData("55", "-150", "55")]//true
        [InlineData("-55", "-100", "55")]//true
        [InlineData("-100", "-55", "10")]//true

        [InlineData("0", "1225", "0")]//true
        [InlineData("31245", "1225", "620")]//true
        [InlineData("31245", "-1225", "620")]//true
        [InlineData("-31245", "1225", "605")]//true
        [InlineData("14255", "2314", "371")]//true
        [InlineData("215511274201", "21652196094271", "215511274201")]//true
        [InlineData("-215511274201", "21652196094271", "215511274201")]//true
        [InlineData("215511274201", "-21652196094271", "215511274201")]//true
        [InlineData("215511274201213412", "215623412345", "201654045157")]// true
        [InlineData("786739364326034", "6438129201506123", "786739364326034")]//true
        [InlineData("215511274201213412", "-215623412345", "201654045157")]//true
        [InlineData("-215511274201213412", "215623412345", "13969367188")]//true
        [InlineData("-215511274201213412", "-215623412345", "13969367188")]//true


        public static void Rest_of_divide(string target, string num, string expexted)
        {
            var n1 = new BigNum(target);
            var n2 = new BigNum(num);
            var exp = new BigNum(expexted);

            Assert.Equal(exp, Z10.MOD_ZZ_Z(n1, n2, out _));
        }
    }
}