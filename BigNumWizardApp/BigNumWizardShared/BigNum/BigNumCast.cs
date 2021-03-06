using System;
using System.Numerics;
using System.Text;

namespace BigNumWizardShared
{
	public partial class BigNum
	{
		public static explicit operator int(BigNum bNum)
		{
			return int.Parse(bNum.ToString());
		}

		public override string ToString()
		{
			var enumerator = number.GetEnumerator();
			var sb = new StringBuilder();
			while (enumerator.MoveNext())
			{
				sb.Insert(0, enumerator.Current);
			}
			if (!Positive) sb.Insert(0, "-");
			return sb.ToString();
		}
	}
}