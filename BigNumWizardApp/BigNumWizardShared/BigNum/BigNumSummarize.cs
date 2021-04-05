using System;
using System.Numerics;

namespace BigNumWizardShared
{
	public partial class BigNum
	{
		// only when abs A > abs B
		public static BigNum operator +(BigNum a, BigNum b)
		{
			if (b.Positive ^ a.Positive)
			{
				BigNum bigger = a > b ? a : b;
				BigNum less = a > b ? b : a;

				BigNum val = bigger - less;
				val.Positive = less.Positive;
				return val;
			}
			// TODO rewrite this shit to normal XOR and other stuff
			if (a.Positive && !b.Positive)
			{
				return a.Absolute - b.Absolute;
			}
			else if (!a.Positive && b.Positive)
			{
				BigNum val = a.Absolute - b.Absolute;
				val.Positive = false;
				return val;
			}
			else if (!a.Positive && !b.Positive)
			{
				BigNum val = a.Absolute + b.Absolute;
				val.Positive = false;
				return val;
			}
			// a and b is positive

			while (a.Lenght < b.Lenght) a.Add(0);
			while (b.Lenght < a.Lenght) b.Add(0);
			// new BigNum(a) to make deep copy
			BigNum newNum = new BigNum(a);
			/*for (var i = 0; i < b.Lenght; i++) {
				newNum.recursiveAdd(a[i], i);
			}*/

			for (var i = 0; i < b.Lenght; i++)
			{
				newNum.recursiveAdd(b[i], i);
			}
			return newNum;
		}

		// TODO move this shit (fukin shit) to this[int key] set
		private void recursiveAdd(byte add, int index)
		{
			while (index >= number.Count)
			{
				Add(0);
			}
			// for (var i = number.Count - 1; i >= 0; i--) { }
			number[index] += add;
			if (number[index] > 9)
			{
				byte nextAdd = (byte)(number[index] / 10);
				recursiveAdd(nextAdd, index + 1);
				number[index] = (byte)(number[index] % 10);
			}
		}
	}
}