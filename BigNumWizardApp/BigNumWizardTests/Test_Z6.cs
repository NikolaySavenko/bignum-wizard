using System;
using Xunit;
using BigNumWizardShared;

namespace BigNumWizardTests
{
    public class Test_Z6 //Kabanov
    {
        [Theory]
        [InlineData("3214124", "241", "3214365")]//true
        [InlineData("987654321", "-214213", "987440108")]//true
        [InlineData("3214124", "0", "3214124")]//false
        [InlineData("987654321", "-2", "987654319")]//false
        //[InlineData("741852963", "-800053625‬", "-58200662")]

        public void Sum_Int_Test(string target, string num, string expexted)
        {
            var n1 = new BigNum(target);
            var n2 = new BigNum(num);
            var sum = Z6.ADD_ZZ_Z(n1, n2);
            
            Assert.Equal(sum, new BigNum(expexted));
        }
    }
}
