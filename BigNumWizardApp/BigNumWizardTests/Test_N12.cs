using Xunit;
using BigNumWizardShared;

namespace BigNumWizardTests
{
    public class Test_N12 // Osiptsov
    {
        [Theory]
        [InlineData("453455255234257535", "3344235544334", "325071377473")]
        [InlineData("1", "1", "0")]
        [InlineData("5545434322565653", "5545434322565653", "0")]
        [InlineData("25", "5", "0")]
        [InlineData("45667777000054534423245563455", "2344555656456553458976435543345454234242345345434", "14218958006268012344443294909")]
        [InlineData("43554543545343423442", "1123423423", "330501168")]
        [InlineData("100000000000000000000000000", "10000000", "0")]
        [InlineData("56655545344353452554", "343423432111111112", "334102478131230186")]
        [InlineData("2", "55554544444333223", "1")]
        [InlineData("5566555343324556544344", "34443", "26421")]

        public void Remainder(string first, string second, string expectedStr)
        {
            var expected = new BigNum(expectedStr);
            var got = N12.DIV_NN_Dk(new BigNum(first), new BigNum(second));
            Assert.Equal(expected, got);
        }
    }
}
