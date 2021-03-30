﻿using Xunit;
using BigNumWizardShared;

namespace BigNumWizardTests
{
    public class Test_Z3    // Osiptsov
    {
        [Theory]
        [InlineData("-12213123123231213123412321", "12213123123231213123412321")]
        [InlineData("0", "0")]
        [InlineData("453456346345345463435253452342", "-453456346345345463435253452342")]
        [InlineData("432432412213123123231213123412321", "-432432412213123123231213123412321")]
        [InlineData("-53453453456352353465454353463454325235235235", "53453453456352353465454353463454325235235235")]
        [InlineData("10000000000000000000000000000000000000000000000000000", "-10000000000000000000000000000000000000000000000000000")]
        [InlineData("-1000000000000000000000000000000000000000000000000000", "1000000000000000000000000000000000000000000000000000")]

        public void MultiplyByMinusOne(string target, string expected)
        {
            var input = new BigNum(target);
            var result = z2_3.MUL_ZM_Z(input);
            Assert.Equal(result, new BigNum(expected));
        }

    }
}
