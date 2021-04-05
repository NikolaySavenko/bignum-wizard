using Xunit;
using BigNumWizardShared;

namespace BigNumWizardTests
{
    public class Test_Z9
    {

        [Theory]
        [InlineData("6", "4","1")]
        [InlineData("777", "111", "7")]
        [InlineData("12533695", "25", "501347")]
        [InlineData("893834783478438743", "8734734763434", "102331")]
        [InlineData("1", "1", "1")]
        [InlineData("-896567007654678900", "100", "-8965670076546789")]
        [InlineData("-954007970733832256788643", "-343433456566654448999", "2777")]
        [InlineData("89467902222222233333333333466678887", "-11019958606653905490", "-8118714907713089")]
        [InlineData("0", "234567794736435654", "0")]



        public void Div(string A, string B, string expected)
        {
            var ex = new BigNum(expected);
            var result = Z9.DIV_ZZ_Z(new BigNum(A), new BigNum(B), out _);
            Assert.Equal(ex, result);
        }
    }

}

