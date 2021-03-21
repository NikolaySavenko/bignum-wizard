using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using BigNumWizardShared;

namespace BigNumWizardTests.Compare
{
	public class ComparePositiveTests
	{
		[Fact]
		public void EqualTest()
		{
			string num1 = "123";
			string num2 = "123";
			BigNum bigNum1 = new BigNum(num1);
			BigNum bigNum2 = new BigNum(num2);
			var a = new List<byte>() { 1, 2, 3 };
			var b = new List<byte>() { 1, 2, 3 };
			var t = a == b;
			Assert.True(bigNum1 == bigNum2);
		}

		[Fact]
		public void NotEqualTest()
		{
			string num1 = "123";
			string num2 = "111";
			BigNum bigNum1 = new BigNum(num1);
			BigNum bigNum2 = new BigNum(num2);
			Assert.True(bigNum1 != bigNum2);
		}

		[Fact]
		public void BiggerTest()
		{
			string num1 = "321";
			string num2 = "123";
			BigNum bigNum1 = new BigNum(num1);
			BigNum bigNum2 = new BigNum(num2);

			Assert.True(bigNum1 > bigNum2);
		}

		[Fact]
		public void BiggerEqualsTest()
		{
			string num1 = "321";
			string num2 = "123";
			BigNum bigNum1 = new BigNum(num1);
			BigNum bigNum2 = new BigNum(num2);

			Assert.True(bigNum1 >= bigNum2);
		}

		[Fact]
		public void LessTest()
		{
			string num1 = "123";
			string num2 = "321";
			BigNum bigNum1 = new BigNum(num1);
			BigNum bigNum2 = new BigNum(num2);

			Assert.True(bigNum1 < bigNum2);
		}

		[Fact]
		public void LessEqualsTest()
		{
			string num1 = "123";
			string num2 = "321";
			BigNum bigNum1 = new BigNum(num1);
			BigNum bigNum2 = new BigNum(num2);

			Assert.True(bigNum1 <= bigNum2);
		}
	}
}
