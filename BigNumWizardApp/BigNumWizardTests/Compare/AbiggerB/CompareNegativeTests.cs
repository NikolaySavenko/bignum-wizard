using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using BigNumWizardShared;

namespace BigNumWizardTests.Compare
{
	public class CompareNegativeTests
	{
		[Theory]
		[InlineData("012412345", "012412345")]
		[InlineData("0", "0")]
		[InlineData("11", "11")]
		[InlineData("-1", "-1")]
		[InlineData("-5877812446235435234435343534", "-5877812446235435234435343534")]
		[InlineData("12446235435234435343534", "12446235435234435343534")]

		public void EqualTest(string n1, string n2)
		{
			var num1 = new BigNum(n1);
			var num2 = new BigNum(n2);
			Assert.True(num1 == num2);
		}

		[Theory]
		[InlineData("-12412345435", "-12412345")]
		[InlineData("0", "-6540")]
		[InlineData("0", "-1")]
		[InlineData("56376563", "-673566540")]
		[InlineData("-875858598585", "67858888888888888880")]

		public void NotEqualTest(string n1, string n2)
		{
			var num1 = new BigNum(n1);
			var num2 = new BigNum(n2);
			Assert.True(num1 != num2);
		}

		[Theory]
		[InlineData("4565012412345435", "-12412345")]
		[InlineData("-456525250", "-6565673657546475467564657567540")]
		[InlineData("565", "1")]
		[InlineData("565763575", "15465")]
		[InlineData("5542245565454565", "0")]
		[InlineData("565", "-679567798691")]
		[InlineData("-454565", "-123324232423")]
		[InlineData("-5", "-11")]

		public void BiggerTest(string n1, string n2)
		{
			var num1 = new BigNum(n1);
			var num2 = new BigNum(n2);
			Assert.True(num1 > num2);
		}

		[Theory]
		[InlineData("4565012412345435", "-12412345")]
		[InlineData("456525250", "-6")]
		[InlineData("-456525250", "-456525250")]
		[InlineData("-45", "-45")]
		[InlineData("-67784786456525250", "-67784786456525250")]

		public void BiggerEqualsTest(string n1, string n2)
		{
			var num1 = new BigNum(n1);
			var num2 = new BigNum(n2);
			Assert.True(num1 >= num2);
		}

		[Theory]
		[InlineData("-4565012412345435", "-12412345")]
		[InlineData("-456525250", "-6")]
		[InlineData("-456565383583825250", "-4")]
		[InlineData("-1", "4356673")]
		[InlineData("-10", "-1")]

		public void LessTest(string n1, string n2)
		{
			var num1 = new BigNum(n1);
			var num2 = new BigNum(n2);
			Assert.True(num1 < num2);
		}

		[Theory]
		[InlineData("-4565012412345435", "-12412345")]
		[InlineData("-456525250", "-6")]
		[InlineData("-456565383583825250", "-4")]
		[InlineData("-1", "4356673")]
		[InlineData("-10", "-1")]
		[InlineData("-10", "-10")]
		[InlineData("-1045625", "-1045625")]
		[InlineData("-16436763", "-10")]
		[InlineData("-1", "0")]

		public void LessEqualTest(string n1, string n2)
		{
			var num1 = new BigNum(n1);
			var num2 = new BigNum(n2);
			Assert.True(num1 <= num2);
		}
	}
}
