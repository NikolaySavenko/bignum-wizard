using System;
using Xunit;
using BigNumWizardShared;

namespace BigNumWizardTests
{
    public class Test_Z2 //Lukina
    {
        [Theory]
        [InlineData("0", "0")]
        [InlineData("9", "2")]
        [InlineData("-7", "1")]
        [InlineData("-1234567890", "1")]
        [InlineData("9876543243", "2")] 

        public void SignCheck(string target, string expexted)
        {
            var n1 = new BigNum(target);
            int n2 = z2_3.POZ_Z_D(n1);
            Assert.Equal(new BigNum(n2.ToString()), new BigNum(expexted));
        }


        [Theory]
        [InlineData("0", "0")]
        [InlineData("9", "2")]
        [InlineData("-7", "1")]
        [InlineData("-1234567890", "1")]
        [InlineData("555", "2")]
        [InlineData("68765432453", "2")] 

        public void SignCheck1(string target, string expexted)
        {
            var n1 = new BigNum(target);
            int n2 = z2_3.POZ_Z_D(n1);
            Assert.True(new BigNum(n2.ToString()) == new BigNum(expexted));
        }


    }
}