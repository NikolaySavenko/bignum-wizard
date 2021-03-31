using Xunit;
using BigNumWizardShared;

namespace BigNumWizardTests
{
    // all tests instead of marked with "passes" fail because of insignificant zeros in actual
   
    public class Test_N13   // Osiptsov
    {
        [Theory]
        [InlineData("45645636566364", "11122344253665436465655455245255352", "4")]
        [InlineData("32434553455423445455242", "1", "1")]
        [InlineData("1", "134453455676890976545331345", "1")]
        [InlineData("5767664565554242324245", "5767664565554242324245", "5767664565554242324245")]  //passes
        [InlineData("1", "1", "1")]             //passes
        [InlineData("5654645346534547", "3455345435645645656547456456345654634565465463466745654", "1")]
        [InlineData("66565343423423233133424233222222222", "45345345", "1")]
        [InlineData("1000", "2221", "1")]
        [InlineData("6655343245524233", "43545245425", "1")]
        [InlineData("334434567990000867643554435356565", "353344667753456745", "15")]
        [InlineData("760493041517621368375", "429092158873329928600", "324545542525")]

        public void GreaterCommonDivisor(string fir, string sec, string expectedStr)
        {
            var first = new BigNum(fir);
            var second = new BigNum(sec);
            var expected = new BigNum(expectedStr);
            var got = N4_13.GCF_NN_N(first, second);

            Assert.Equal(expected, got);
        }
    }
}
