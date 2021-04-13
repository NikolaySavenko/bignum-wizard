using System;
using Xunit;
using BigNumWizardShared;

namespace BigNumWizardTests
{
    public class Test_N6 //Lukina, Pukha
    {
        [Theory]
        [InlineData("12345679", 9, "111111111")]
        [InlineData("987654321", 0, "0")]
        [InlineData("741852963", 3, "2225558889")]
        [InlineData("345345667787899788545645700005432", 1, "345345667787899788545645700005432")]
        [InlineData("99999959999995993945939999934959349599234", 9, "899999639999963945513459999414634146393106")]
        [InlineData("5", 8, "40")]
        [InlineData("5645675758865634534234235356457578689856456344523425", 0, "0")]
        [InlineData("56786756654545534424245000000000000000000000000000000000", 4, "227147026618182137696980000000000000000000000000000000000")]
        [InlineData("10000000000000000000000000000000000000000", 2, "20000000000000000000000000000000000000000")]
        [InlineData("1111111111111111111111111111111111111111111111", 6, "6666666666666666666666666666666666666666666666")]

        public void MultiplyByNumber(string target, byte num, string expexted)
        {
            var n1 = new BigNum(target);
            n1 = N2_6.MUL_ND_N(n1, num);
            Assert.Equal(n1, new BigNum(expexted));
        }
    }
}
