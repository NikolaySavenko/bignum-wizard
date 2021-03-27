using System.Numerics;

namespace BigNumWizardShared
{
	public partial class BigNum
	{
		public static BigNum operator /(BigNum a, BigNum b)
		{
			return new BigNum((BigInteger.Parse((string)a) / BigInteger.Parse((string)b)).ToString());
		}

		public static BigNum operator %(BigNum a, BigNum b)
		{
			return new BigNum((BigInteger.Parse((string)a) % BigInteger.Parse((string)b)).ToString());
		}

		public BigNum Divide(BigNum divider, out BigNum remainer)
		{
			if (divider > this)
			{
				remainer = this;
				return new BigNum(this);
			}
			remainer = new BigNum("0");
			return new BigNum("1");
		}

		private void RecursiveDivide()
		{

		}
	}
}