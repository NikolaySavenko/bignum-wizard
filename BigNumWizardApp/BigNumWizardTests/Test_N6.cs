using System;
using Xunit;
using BigNumWizardShared;

namespace BigNumWizardTests
{
    public class Test_N6 //Lukina
    {
        [Theory]
        [InlineData("12345679", 9, "111111111")]
        [InlineData("987654321", 0, "0")] //не работает, возвращает массив нулей
        [InlineData("741852963", 3, "2225558889")]

        public void MultiplyByNNumber(string target, byte num, string expexted)
        {
            var n1 = new BigNum(target);
            n1.MultiplyByNumeral(num);
            Assert.Equal(n1, new BigNum(expexted));
        }
    }
}
