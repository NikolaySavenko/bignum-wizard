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
		[InlineData("1", "0")]
		[InlineData("12409876543298765432876543", "127654323455434")]
		[InlineData("6666", "6")]
		[InlineData("12409876543298765432876544", "12409876543298765432876543")]
		[InlineData("6666", "-6")]
		[InlineData("-1234560987476575756477876546373637", "-123445445609876565476376543456434567768765676")]
		[InlineData("-123456", "-198765432")]
		[InlineData("0", "-19876543764872")]

		public void CompareLenT(string n1, string n2)
		{
			var num1 = new BigNum(n1);
			var num2 = new BigNum(n2);
			Assert.True(num1 > num2);
		}

		[Theory]
		[InlineData("12412345", "123")]
		[InlineData("1234524", "12200")]
		[InlineData("876987686786876876987576576196565352430234524", "122012123132132132231230")]
		[InlineData("12446", "123")]
		[InlineData("12446235435234435343534", "1")]
		[InlineData("124462354098735234435343534", "-1")]
		[InlineData("-6533755", "-89897895875")]
		[InlineData("-111111", "-56545465545")]
		[InlineData("-111111434857553248978523532453", "-5654546553453523425452347895785953242423435234545")]

		public void CompareLenF(string n1, string n2)
		{
			var num1 = new BigNum(n1);
			var num2 = new BigNum(n2);
			Assert.False(num1 < num2);
		}

		[Theory]
		[InlineData("012412345", "012412345")]
		[InlineData("0", "0")]
		[InlineData("11", "11")]
		[InlineData("-1", "-1")]
		[InlineData("-5877812446235435234435343534", "-5877812446235435234435343534")]
		[InlineData("12446235435234435343534", "12446235435234435343534")]

		public void CompareLenE(string n1, string n2)
		{
			var num1 = new BigNum(n1);
			var num2 = new BigNum(n2);
			Assert.Equal(num1, num2);
		}
	}
}
