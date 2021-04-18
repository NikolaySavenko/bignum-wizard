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
        [InlineData("3214124", "0", "3214124")]//true
        [InlineData("987654321", "-2", "987654319")]//true
        [InlineData("-1", "-2", "-3")]//true
        [InlineData("1", "2", "3")]//true
        [InlineData("-3", "4", "1")]//true
        [InlineData("-7053625", "6418528", "-635097")] //true

        [InlineData("-800053625", "741852963‬", "-58200662")] //false

        [InlineData("-8053625", "7418528‬", "-635097")] //false

        [InlineData("-9053625", "8418529‬", "-635096")] //false

        [InlineData("7418529‬", "-8053625", "-635096")]//false

        [InlineData("-80214", "4216521231‬", "4216441017")]//false

        [InlineData("0", "0‬", "0")]//false

        [InlineData("14218752198", "0", "14218752198")]//true
        [InlineData("0", "14218752198", "14218752198")]//true
        [InlineData("0", "-14218752198", "-14218752198")]//true
        [InlineData("-14218752198", "0", "-14218752198")]//true

        [InlineData("-4250902", "241566412768", "241562161866")]//true
        [InlineData("-7", "5", "-2")]//true
        [InlineData("5", "-7", "-2")]//true
        [InlineData("10", "-7", "3")]//true
        [InlineData("-10", "7", "-3")]//true
        [InlineData("-15214214215", "4215872", "-15209998343")]//true
        [InlineData("15214214215", "-4215872", "15209998343")]//true


        [InlineData("214125125213", "-55212121562158291", "-55211907437033078")]//true
        [InlineData("2175656219820", "-5621967821705012", "-5619792165485192")]//true
        [InlineData("-5621967821705012", "2175656219820", "-5619792165485192")]//true
        [InlineData("5621967821705012", "-2175656219820", "5619792165485192")]//true


        [InlineData("21678021304021", "-78921790002415421", "-78900111981111400")]//true
        [InlineData("-11256787213", "-24621787592", "-35878574805")]//true
        [InlineData("5", "-6", "-1")]//true

        public void Sum_Int_Test(string target, string num, string expexted)
        {
            var n1 = new BigNum(target);
            var n2 = new BigNum(num);
            var sum = Z6.ADD_ZZ_Z(n1, n2);
            
            Assert.Equal(sum, new BigNum(expexted));
        }
    }
}
