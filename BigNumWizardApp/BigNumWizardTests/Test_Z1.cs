using System;
using Xunit;
using BigNumWizardShared;

namespace BigNumWizardTests
{
    public class Test_Z1 //Petrakova
    {
        [Theory]
        [InlineData("-27328744834", "27328744834")]
        [InlineData("0","0")]
        [InlineData("5434664634264", "5434664634264")]
        [InlineData("-1536285375392489054435698654331429", "1536285375392489054435698654331429")]
        [InlineData("-1","1")]
        [InlineData("45454565667678899999885654543342323322345566453435", "45454565667678899999885654543342323322345566453435")]
        [InlineData("-122134543543323345", "122134543543323345")]
        [InlineData("-9123449453534232423456654342332424543245", "9123449453534232423456654342332424543245")]
        [InlineData("34325","34325")]
        [InlineData("-9123432456543", "9123432456543")]

        public void AbsoluteValue(string target, string expected)
        {
            Assert.Equal(Absolute.ABS_Z_N(new BigNum(target)), new BigNum(expected));
        }
    }
}
