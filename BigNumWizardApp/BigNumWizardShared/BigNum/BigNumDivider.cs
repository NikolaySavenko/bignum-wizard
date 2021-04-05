using System;
using System.Numerics;

namespace BigNumWizardShared
{
	public partial class BigNum
	{
		public static BigNum operator /(BigNum a, BigNum b)
		{
			return Divide(a, b, out var _);
		}

		public static BigNum operator %(BigNum a, BigNum b)
		{
			Divide(a, b, out var rem);
			return rem;
		}

		public static BigNum Divide(BigNum source, BigNum divider, out BigNum remainer)
		{
			// Please make this shit normal
			// im so sorry for that
			// edited division
			// i hope it's normal
			if (source.Positive ^ divider.Positive) {
				var absResult = Divide(source.Absolute, divider.Absolute, out remainer);
				absResult.Positive = false;
				return absResult;
			}
			// A and B is positive
			var rem = new BigNum(source);
			var result = BigNum.Zero;

			while (rem >= divider)
			{
				var tmp = new BigNum(divider);
				var power = 0;
				var ten = 10;
				var count = 0;
				while (tmp * new BigNum(Math.Pow(ten, power + 1).ToString()) < rem)
				{
					tmp = N3_N7.MUL_Nk_N(tmp, power+1);
					count++;
				}
				while (rem - tmp >= BigNum.Zero)
				{
					rem -= tmp;
					result += new BigNum(Math.Pow(ten, power + count).ToString());
				}
			}
			remainer = rem;
			DeleteInsignificantZeros(ref remainer);
			DeleteInsignificantZeros(ref result);
			return result;
		}
	}
}