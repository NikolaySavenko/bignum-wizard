using System;
using Xunit;
using BigNumWizardShared;

namespace BigNumWizardTests
{
    public class Test_N4 //Pukha
    {
        [Theory]
        [InlineData("0", "0", "0")]
        [InlineData("0", "75", "75")]
        [InlineData("8", "0", "8")]
        [InlineData("0", "2342569883475625524333333452", "2342569883475625524333333452")]
        [InlineData("9872659784269762865", "0", "9872659784269762865")]
        [InlineData("654", "34567890765434", "34567890766088")]
        [InlineData("867564543345468", "2", "867564543345470")]
        [InlineData("9786756453423434", "11111111111111", "9797867564534545")]
        [InlineData("73737373737373737373737373", "3737373737373737373737373737373737", "3737373811111111111111111111111110")]
        [InlineData("888888888888888888", "100000000000000000", "988888888888888888")]
        [InlineData("321321321", "3000000002", "3321321323")]

        public void Plus_NN(string target1, string target2, string expected)
        {
            var n1 = new BigNum(target1);
            var n2 = new BigNum(target2);
            var result = N4_13.ADD_NN_N(n1, n2);
            Assert.Equal(result, new BigNum(expected));
        }
    }
}
