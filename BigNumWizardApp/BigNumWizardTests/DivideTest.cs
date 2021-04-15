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
		public void SimpleDivide(string target, string num, string expected)
		{
			var n1 = new BigNum(target);
			var n2 = new BigNum(num);
			var div = n1 / n2;
			Assert.Equal(div, new BigNum(expected));
		}
	}
}
