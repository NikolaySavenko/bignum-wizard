using BigNumWizardShared;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BigNumWizardTests.Compare
{
	
	public class CompareTest
	{
		[Theory]
		[InlineData("0124", "123")]
		[InlineData("123", "122")]
		[InlineData("124", "123")]
		public void CompareLen(string n1, string n2)
		{
			var num1 = new BigNum(n1);
			var num2 = new BigNum(n2);
			var t = num1.CompareTo(num2);
			Assert.True(num1 > num2);
		}
	}
}
