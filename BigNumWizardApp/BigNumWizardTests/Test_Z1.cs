using System;
using Xunit;
using BigNumWizardShared;

namespace BigNumWizardTests
{
    public class Test_Z1
    {
        [Theory]
        [InlineData("-27328744834", "27328744834")]
        [InlineData("0","0")]
        [InlineData("5434664634264", "5434664634264")]
        [InlineData("-1536285375392489054435698654331429", "1536285375392489054435698654331429")]
        [InlineData("-1","1")]

        public void AbsoluteValue(string target, string expected)
        {
            Assert.Equal(Absolute.ABS_Z_N(new BigNum(target)), new BigNum(expected));
        }
    }
}
