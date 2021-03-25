using System;
using Xunit;
using BigNumWizardShared;

namespace BigNumWizardTests
{
	public class SimpleNegativeMultiply
	{
		[Theory]
		[InlineData("12345679", "-11", "-135802469")]
		[InlineData("-199199199199", "-31", "6175175175169")]
		[InlineData("-7899877899996", "21", "-165897435899916")]
		[InlineData("982", "99", "97218")]
		public void MultiplyByNumber(string target, string num, string expected)
		{
			var n1 = new BigNum(target);
			var n2 = new BigNum(num);
			var mult = n1 * n2;
			Assert.Equal(mult, new BigNum(expected));
		}
	}
}
