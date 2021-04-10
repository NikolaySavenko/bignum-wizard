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
        //[InlineData("-55", "-100", "55")]
        //[InlineData("-100", "-55", "10")]

        [InlineData("31245", "1225", "620")]//true
        [InlineData("31245", "-1225", "620")]//true
        [InlineData("-31245", "1225", "605")]//true


        public void Rest_of_divide(string target, string num, string expexted)
        {

            var n1 = new BigNum(target);
            var n2 = new BigNum(num);
            var sum = Z10.MOD_ZZ_Z(n1, n2, out _);

            Assert.Equal(sum, new BigNum(expexted));
        }
    }
}
