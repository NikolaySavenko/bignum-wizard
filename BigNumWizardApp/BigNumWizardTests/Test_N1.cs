using System;
using Xunit;
using BigNumWizardShared;

namespace BigNumWizardTests
{
    public class Test_N1 //Pukha
    {
        [Theory]
        [InlineData("0", "0", 0)]
        [InlineData("0", "897", 1)]
        [InlineData("12", "0", 2)]
        [InlineData("4567890034298877650324985", "4567890034298877650324985", 0)]
        [InlineData("0", "23456789785453578457867", 1)]
        [InlineData("11111111111111111111111111111111", "9999999", 2)]
        [InlineData("4", "4", 0)]
        [InlineData("6666666664444443333332222222221111111111", "6666666664444443333332222222221111111112", 1)]
        [InlineData("343434343434343434343434", "343434343434343434343433", 2)]
        [InlineData("100000", "9999", 2)]
        [InlineData("1020382754246328749823569823746783478684365973225987", "1020382754246328749823569823746783478684365973225987", 0)]
        [InlineData("555543", "599999", 1)]
        [InlineData("87923646587", "100000000000000000000000000", 1)]
        [InlineData("1", "9637846732945867", 1)]
        [InlineData("234659186239276", "2", 2)]

        public void CompareOfNumber(string target1, string target2, byte expected)
        {
            var n1 = new BigNum(target1);
            var n2 = new BigNum(target2);
            var result = Natural1_5.COM_NN_D(n1, n2);
            Assert.Equal(result, expected);
        }
    }
}
