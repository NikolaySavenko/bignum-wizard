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

            if (divider == BigNum.One)
            {
                remainer = BigNum.Zero;
                return source;
            }
            if (source.Positive ^ divider.Positive) {
				var absResult = Divide(source.Absolute, divider.Absolute, out remainer);
				absResult.Positive = false;
				return absResult;
			}
			if ((source.Positive == false)&(divider.Positive == false))
            {
				var absResult = Divide(source.Absolute, divider.Absolute, out remainer);
				absResult.Positive = true;
				return absResult;
			}

			// A and B is positive
			var rem = new BigNum(source);
			var result = BigNum.Zero;

			while (rem >= divider)
			{
				var tmp = new BigNum(divider);
				var save_tmp = new BigNum(tmp);
				BigNum ten_degree;
				var one = new BigNum("1");
				var power = 0;
				var count = 0;
				
				while (N3_N7.MUL_Nk_N(save_tmp, power + 1) < rem)
				{
					tmp = N3_N7.MUL_Nk_N(tmp, power+1);
					count++;
				}
				
				ten_degree = N3_N7.MUL_Nk_N(one, power + count);
				while (rem - tmp >= BigNum.Zero)
				{
					rem -= tmp;
					result += ten_degree;
				}
			}
			remainer = rem;
			DeleteInsignificantZeros(remainer, result);
			return result;
		}
	}
}