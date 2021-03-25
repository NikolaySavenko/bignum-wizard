using System;
using Xunit;
using BigNumWizardShared;

namespace BigNumWizardTests
{
	public class SimpleMultiply
	{
		[Theory]
		[InlineData("1111", 4, "4444")]
		[InlineData("123456789123456", 4, "493827156493824")]
		[InlineData("1111", 1, "1111")]
		[InlineData("12345679", 9, "111111111")]
		public void CommonNumeralMultiply(string target, byte numeral, string expected)
		{
			var num = new BigNum(target);
			num.MultiplyByNumeral(numeral);
			Assert.Equal(num, new BigNum(expected));
		}

		[Theory]
		[InlineData("567", 2, "1134")]
		[InlineData("999", 9, "8991")]
		[InlineData("982", 5, "4910")]
		public void CommonNumeralOverMultiply(string target, byte numeral, string expected)
		{
			var num = new BigNum(target);
			num.MultiplyByNumeral(numeral);
			Assert.Equal(num, new BigNum(expected));
		}

		[Theory]
		[InlineData("12345679", "11", "135802469")]
		[InlineData("199199199199", "31", "6175175175169")]
		[InlineData("7899877899996", "21", "165897435899916")]
		[InlineData("982", "99", "97218")]
		public void MultiplyByNumber(string target, string num, string expected)
		{
			var n1 = new BigNum(target);
			var n2 = new BigNum(num);
			Assert.Equal(n1 * n2, new BigNum(expected));
		}

		[Theory]
		[InlineData("1531", "0", "0")]
		[InlineData("999", "0", "0")]
		[InlineData("982", "0", "0")]
		public void ZeroMultiply(string target, string num, string expected)
		{
			var n1 = new BigNum(target);
			var n2 = new BigNum(num);
			Assert.Equal(n1 * n2, new BigNum(expected));
		}
	}
}
