using System;
using Xunit;
using BigNumWizardShared;

namespace BigNumWizardTests
{
	public class SubtractionBigNumTest
	{
		[Fact]
		public void CommonNumTest()
		{
			string num = "12345";
			BigNum bigNum = new BigNum(num);

			Assert.Equal(num, ((int)bigNum).ToString());
		}

		[Fact]
		public void ZeroTest()
		{
			string num = "0";
			BigNum bigNum = new BigNum(num);

			Assert.Equal(num, ((int)bigNum).ToString());
		}

		[Fact]
		public void OverHeatTest()
		{
			string num1 = "9";
			string num2 = "9";
			BigNum bigNum1 = new BigNum(num1);
			BigNum bigNum2 = new BigNum(num2);
			BigNum substr = bigNum1 - bigNum2;

			Assert.Equal(BigNum.Zero, substr);
		}

		[Fact]
		public void EqualSubTest()
		{
			string num1 = "123";
			string num2 = "123";
			BigNum bigNum1 = new BigNum(num1);
			BigNum bigNum2 = new BigNum(num2);
			BigNum substr = bigNum1 - bigNum2;

			Assert.Equal(BigNum.Zero, substr);
		}


		[Fact]
		public void MiddleOverHeatTest()
		{
			string num1 = "999";
			string num2 = "999";
			BigNum bigNum1 = new BigNum(num1);
			BigNum bigNum2 = new BigNum(num2);
			BigNum substr = bigNum1 - bigNum2;

			Assert.Equal(BigNum.Zero, substr);
		}

		[Fact]
		public void RowTest()
		{
			string num1 = "321";
			string num2 = "123";
			BigNum bigNum1 = new BigNum(num1);
			BigNum bigNum2 = new BigNum(num2);
			BigNum substr = bigNum1 - bigNum2;

			Assert.Equal(new BigNum("198"), substr);
		}

		[Fact]
		public void UnderZeroSubstraction()
		{
			string num1 = "123";
			string num2 = "124";
			BigNum bigNum1 = new BigNum(num1);
			BigNum bigNum2 = new BigNum(num2);
			BigNum substr = bigNum1 - bigNum2;

			Assert.Equal(new BigNum("-1"), substr);
		}

		[Fact]
		public void MixedSubstraction()
		{
			string num1 = "124";
			string num2 = "1244";
			BigNum bigNum1 = new BigNum(num1);
			BigNum bigNum2 = new BigNum(num2);
			BigNum substr = bigNum1 - bigNum2;

			Assert.Equal(new BigNum("-1120"), substr);
		}
	}
}
