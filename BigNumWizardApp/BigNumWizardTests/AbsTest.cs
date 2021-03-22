using BigNumWizardShared;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BigNumWizardTests.Negative
{
	public class AbsTest
	{
		[Fact]
		public void PositiveAbsTest()
		{
			var num = new BigNum("123");
			Assert.Equal(new BigNum("123"), num.Absolute);
		}

		[Fact]
		public void PositiveCharAbsTest()
		{
			var num = new BigNum("+123");
			Assert.Equal(new BigNum("123"), num.Absolute);
		}

		[Fact]
		public void NegativeAbsTest()
		{
			var num = new BigNum("-123");
			Assert.Equal(new BigNum("123"), num.Absolute);
		}

		[Fact]
		public void ZeroAbsTest()
		{
			var num = new BigNum("0");
			Assert.Equal(new BigNum("0"), num.Absolute);
		}
	}
}
