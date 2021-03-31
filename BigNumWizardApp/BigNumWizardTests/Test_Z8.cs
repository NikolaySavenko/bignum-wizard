using System;
using Xunit;
using BigNumWizardShared;

namespace BigNumWizardTests
{
    public class Test_Z8 //Petrakova
    {
        [Theory]
        [InlineData("1","2","2")]
        [InlineData("54578867754","64575734","3524470446103481436")]
        [InlineData("-238059","-766264643", "182416194647937")]
        [InlineData("-53783","184","-9896072")]
        [InlineData("0","487687397","0")]
        [InlineData("0","0","0")]
        [InlineData("-8467598","0","0")]
        [InlineData("264464","-47854","-12655660256")]
        [InlineData("0","-63758233563563236","0")]
        [InlineData("3758525932686532","0","0")]
        [InlineData("5832575393752849359825652302585328535326825332553225325","-1", "-5832575393752849359825652302585328535326825332553225325")]
        [InlineData("373846568343677434646372315057757", "373846568343677434646372315057757", "139761256662343883001295346354225866169128144784200276598245871049")]
        [InlineData("11111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111","1", "11111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111")]

        public void MuliplyInteger(string target, string num, string expected)
        {
            Assert.Equal(Z8.MUL_ZZ_Z(new BigNum(target), new BigNum(num)), new BigNum(expected));
        }
    }
}
