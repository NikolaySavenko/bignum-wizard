using System;
using System.Numerics;

namespace BigNumWizardShared
{
	public partial class BigNum
	{
		public static BigNum operator /(BigNum a, BigNum b)
		{
			return Divide(a, b, out var rem);
		}

		public static BigNum operator %(BigNum a, BigNum b)
		{
			return new BigNum((BigInteger.Parse((string)a) % BigInteger.Parse((string)b)).ToString());
		}

		public static BigNum Divide(BigNum source, BigNum divider, out BigNum remainer)
		{
			// Please make this shit normal
			// im so sorry for that
			var rem = new BigNum(source);
			var result = new BigNum();
			while (rem > divider)
			{
				var tmp = new BigNum(divider);
				var power = 0;
				var ten = 10;
				while (tmp * new BigNum(Math.Pow(ten, power + 1).ToString()) < rem)
				{
					tmp *= new BigNum(Math.Pow(ten, power + 1).ToString());
				}
				while (rem - tmp > BigNum.Zero)
				{
					rem -= tmp;
					result += new BigNum(Math.Pow(ten, power).ToString());
				}
			}
			remainer = rem;
			return new BigNum("1");
		}
	}
}