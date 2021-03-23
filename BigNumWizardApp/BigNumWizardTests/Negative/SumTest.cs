using BigNumWizardShared;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BigNumWizardTests.Negative
{
	public class SumTest 
	{
		[Fact]
		public void StarterSumTest()
		{
			string num1 = "12";
			string num2 = "12";
			BigNum bigNum1 = new BigNum(num1);
			BigNum bigNum2 = new BigNum(num2);
			BigNum sum = bigNum1 + bigNum2;

			Assert.Equal(new BigNum("24"), sum);
		}
		[Fact]
		public void SimpleZeroSumTest()
		{
			string num1 = "9";
			string num2 = "-9";
			BigNum bigNum1 = new BigNum(num1);
			BigNum bigNum2 = new BigNum(num2);
			BigNum sum = bigNum1 + bigNum2;

			Assert.Equal(new BigNum("0"), sum);
		}


		[Fact]
		public void ALessZeroSumTest()
		{
			string num1 = "-9";
			string num2 = "9";
			BigNum bigNum1 = new BigNum(num1);
			BigNum bigNum2 = new BigNum(num2);
			BigNum sum = bigNum1 + bigNum2;

			Assert.Equal(new BigNum("0"), sum);
		}

		[Fact]
		public void ABLessZeroSumTest()
		{
			string num1 = "-9";
			string num2 = "-9";
			BigNum bigNum1 = new BigNum(num1);
			BigNum bigNum2 = new BigNum(num2);
			BigNum sum = bigNum1 + bigNum2;

			Assert.Equal(new BigNum("-18"), sum);
		}

		[Fact]
		public void SuperSumTest()
		{
			string num1 = "1234567123456712345671234567";
			string num2 = "-7654321765432176543217654321";
			BigNum bigNum1 = new BigNum(num1);
			BigNum bigNum2 = new BigNum(num2);
			BigNum sum = bigNum1 + bigNum2;

			Assert.Equal(new BigNum("-6419754641975464197546419754"), sum);
		}

		[Fact]
		public void SuperSumRevertTest()
		{
			string num1 = "-7654321765432176543217654321";
			string num2 = "1234567123456712345671234567";
			BigNum bigNum1 = new BigNum(num1);
			BigNum bigNum2 = new BigNum(num2);
			BigNum sum = bigNum1 + bigNum2;

			Assert.Equal(new BigNum("-6419754641975464197546419754"), sum);
		}

		[Fact]
		public void DifferentSuperMegaOverHeatTest()
		{
			string num1 = "12345671234567123456712345671234567";
			string num2 = "7654321765432176543217654321";
			BigNum bigNum1 = new BigNum(num1);
			BigNum bigNum2 = new BigNum(num2);
			BigNum sum = bigNum1 + bigNum2;

			Assert.Equal(new BigNum("12345678888888888888888888888888888"), sum);
		}

		[Fact]
		public void DifferenSmallTest()
		{
			string num1 = "89";
			string num2 = "9";
			BigNum bigNum1 = new BigNum(num1);
			BigNum bigNum2 = new BigNum(num2);
			BigNum sum = bigNum1 + bigNum2;

			Assert.Equal(new BigNum("98"), sum);
		}
	}
}
