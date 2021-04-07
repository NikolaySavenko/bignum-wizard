using BigNumWizardShared;
using System.Collections.Generic;
using Xunit;

namespace BigNumWizardTests
{
	public class Test_P12 //Solovieva
	{
		[Theory, MemberData(nameof(Data))]

		public static void Derivative(int m, List<BigFraction> C, Polynomial res)
		{
			var actual = P12.DER_P_P(m, C);
			Assert.Equal(actual, res);
		}

		public static IEnumerable<object[]> Data => new[]
				{
					new object[]
					{
						1,
						new List<BigFraction>() { new BigFraction(BigNum.One), new BigFraction(new BigNum("2")) },
						new Polynomial(BigNum.Zero, new List<BigFraction>(){new BigFraction(new BigNum("2"))})
					},

					new object[]
					{
						2,
						new List<BigFraction>() { new BigFraction(BigNum.One), new BigFraction(BigNum.Zero), new BigFraction(new BigNum("2344")) },
						new Polynomial(BigNum.One,new List<BigFraction>(){new BigFraction(BigNum.Zero),new BigFraction(new BigNum("4688"))})
					},

					new object[]
					{
						3,
						new List<BigFraction>() { new BigFraction(new BigNum("34798547874")), new BigFraction(new BigNum("4")), new BigFraction(new BigNum("7654")), new BigFraction(new BigNum("2344")) },
						new Polynomial(new BigNum(),new List<BigFraction>(){new BigFraction(new BigNum("4")), new BigFraction(new BigNum("15308")), new BigFraction(new BigNum("7032"))})
					},
				};

	}
}