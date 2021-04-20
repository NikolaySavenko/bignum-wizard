using System;
using Xunit;
using BigNumWizardShared;

namespace BigNumWizardTests
{
	public class DivideTest
	{
		[Theory]
		[InlineData("123", "10", "12")]
		[InlineData("123", "123", "1")]
		[InlineData("124", "123", "1")]
		[InlineData("123456789098765431234567890", "1", "123456789098765431234567890")]
		[InlineData("79842984864198416724697198927219857", "32654721848125748216", "2445067063671255")]
		[InlineData("123456789098765431234", "1", "123456789098765431234")]
		[InlineData("12345678909876543", "1", "12345678909876543")]//tr
		[InlineData("123456789098765435", "1", "123456789098765435")]
		[InlineData("100000000000000000", "1", "100000000000000000")]//tr

		[InlineData("100000000000000001", "6548", "15271838729383")]
		[InlineData("1000000000000000012", "9", "111111111111111112")]
		[InlineData("100000000000000001", "9", "11111111111111111")]
		public void SimpleDivide(string target, string num, string expected)
		{
			var n1 = new BigNum(target);
			var n2 = new BigNum(num);
			var div = n1 / n2;
			Assert.Equal(div, new BigNum(expected));
		}
	}
}
