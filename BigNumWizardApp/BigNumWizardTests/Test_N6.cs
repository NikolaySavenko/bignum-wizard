using System;
using Xunit;
using BigNumWizardShared;

namespace BigNumWizardTests
{
    public class Test_N6 //Lukina, Pukha
    {
        [Theory]
        [InlineData("12345679", 9, "111111111")]
        [InlineData("987654321", 0, "0")] //ошибка, возвращает массив нулей, а не 0
        [InlineData("741852963", 3, "2225558889")]

        public void MultiplyByNumber(string target, byte num, string expexted)
        {
            var n1 = new BigNum(target);
            n1 = N2_6.MUL_ND_N(n1, num);
            Assert.Equal(n1, new BigNum(expexted));
        }
    }
}
