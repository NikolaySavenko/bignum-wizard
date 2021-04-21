using System;
using System.Runtime.InteropServices;
using Xunit;
using BigNumWizardShared;

namespace BigNumWizardTests
{
    public class Test_N5 //Lukina
    {
        [Theory]
        [InlineData("12345", "12344", "1")]
        [InlineData("123", "12", "111")]
        [InlineData("9990", "9990", "0")]
        [InlineData("9", "7", "2")]
        [InlineData("99999999999", "55555555555", "44444444444")]
        [InlineData("9876543", "7654321", "2222222")]
        [InlineData("9876543", "7", "9876536")]
        [InlineData("8888888888888", "8888888888888", "0")]

        public void Substraction(string target1, string target2, string expexted)
        {
            var n1 = new BigNum(target1);
            var n2 = new BigNum(target2);
            var n3 = Natural1_5.SUB_NN_N(n1, n2);
            Assert.Equal(n3, new BigNum(expexted));
        }
        
        [Theory]
        [InlineData("7", "9", "2")]
        [InlineData("98", "777777777777", "777777777679")]
        public void SubstractionExcept(string target1, string target2, string expexted)
        {
            var n1 = new BigNum(target1);
            var n2 = new BigNum(target2);
            var ex = Assert.Throws<Exception>(() => Natural1_5.SUB_NN_N(n1, n2));
            Assert.Equal("Второе число больше первого!", ex.Message);
        }
    }
}