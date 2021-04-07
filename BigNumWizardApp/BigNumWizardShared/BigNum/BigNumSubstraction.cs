using System;
using System.Numerics;

namespace BigNumWizardShared
{
	public partial class BigNum
	{
		// only when abs A > abs B
		public static BigNum operator -(BigNum a, BigNum b)
		{
			if (b.Positive ^ a.Positive)
			{
				BigNum absBigger = a.Absolute > b.Absolute ? a : b;
				BigNum absLess = a.Absolute > b.Absolute ? b : a;

				BigNum val = absBigger.Absolute - absLess.Absolute;
				val.Positive = absBigger.Positive;
				return val;
			}
			if (b.Absolute > a.Absolute)
			{
				BigNum val = b.Absolute - a.Absolute;
				val.Positive = !a.Positive;
				return val;
			}
			// TODO rewrite this shit to normal XOR and other stuff
			if (a.Positive && !b.Positive)
			{
				return a.Absolute + b.Absolute;
			}
			else if (!a.Positive && b.Positive)
			{
				BigNum val = a.Absolute + b.Absolute;
				val.Positive = false;
				return val;
			}
			else if (!a.Positive && !b.Positive)
			{
				BigNum val = a.Absolute - b.Absolute;
				val.Positive = false;
				return val;
			}
			// a and b is positive

			while (a.Lenght < b.Lenght) a.Add(0);
			while (b.Lenght < a.Lenght) b.Add(0);
			BigNum newNum = new BigNum(a);
			// ITS A TRAP!
			for (var i = 0; i < b.Lenght; i++) newNum.recursivePick(b[i], i);
			DeleteInsignificantZeros(newNum, a, b);
			return newNum;
		}

		// TODO move this shit (fukin again shit) to this[int key] set
		private void recursivePick(byte pick, int index)
		{
			// TODO check index + 1
			while (number.Count < index + 1)
			{
				number.Add(0);
			}
			if (number[index] < pick)
			{
				recursivePick(1, index + 1);
				number[index] += 10;
			}
			number[index] -= pick;
		}
	}
}