using System;
using Xunit;
using BigNumWizardShared;

namespace BigNumWizardTests
{
	public class SumBigNumTest
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
			BigNum sum = bigNum1 + bigNum2;

			Assert.Equal(new BigNum("18"), sum);
		}


		[Fact] 
		public void MiddleOverHeatTest()
		{
			string num1 = "999";
			string num2 = "999";
			BigNum bigNum1 = new BigNum(num1);
			BigNum bigNum2 = new BigNum(num2);
			BigNum sum = bigNum1 + bigNum2;

			Assert.Equal(new BigNum("1998"), sum);
		}

		[Fact]
		public void MegaOverHeatTest()
		{
			string num1 = "12345671234567";
			string num2 = "76543217654321";
			BigNum bigNum1 = new BigNum(num1);
			BigNum bigNum2 = new BigNum(num2);
			BigNum sum = bigNum1 + bigNum2;

			Assert.Equal(new BigNum("88888888888888"), sum);
		}

		[Fact]
		public void SuperMegaOverHeatTest()
		{
			string num1 = "1234567123456712345671234567";
			string num2 = "7654321765432176543217654321";
			BigNum bigNum1 = new BigNum(num1);
			BigNum bigNum2 = new BigNum(num2);
			BigNum sum = bigNum1 + bigNum2;

			Assert.Equal(new BigNum("8888888888888888888888888888"), sum);
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
	}
}
