using System;
using Xunit;
using BigNumWizardShared;

namespace BigNumWizardTests
{
	public class Test_N7 //Bratsun
	{
		[Theory]
		[InlineData("1", 3, "1000")]
		[InlineData("98764242321", 5, "9876424232100000")] 
		[InlineData("-222222222222222", 11, "-22222222222222200000000000")]
		[InlineData("900000000000000", 1, "9000000000000000")]
		[InlineData("13", 1, "130")]
		[InlineData("189301", 10, "1893010000000000")]
		[InlineData("99999999999", 17, "9999999999900000000000000000")]

		public void tenk_Int_Test(string num1, int k, string expected) 
        {
			var n1 = new BigNum(num1);
			n1 = N3_N7.MUL_Nk_N(n1, k);
			Assert.Equal(n1, new BigNum(expected));
		}
	}
}
