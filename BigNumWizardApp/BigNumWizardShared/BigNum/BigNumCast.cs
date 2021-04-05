using System;
using System.Numerics;
using System.Text;

namespace BigNumWizardShared
{
	public partial class BigNum
	{
		public static explicit operator int(BigNum bNum)
		{
			return int.Parse((string)bNum);
		}

		public static explicit operator string(BigNum bNum)
		{
			var enumerator = bNum.number.GetEnumerator();
			var sb = new StringBuilder();
			while (enumerator.MoveNext())
			{
				sb.Insert(0, enumerator.Current);
			}
			if (!bNum.Positive) sb.Insert(0, "-");
			return sb.ToString();
		}
	}
}