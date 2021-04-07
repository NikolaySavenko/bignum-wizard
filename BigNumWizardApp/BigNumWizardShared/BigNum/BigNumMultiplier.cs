using System;
using System.Collections.Generic;
using System.Text;

namespace BigNumWizardShared
{
	public partial class BigNum
	{

		public static BigNum operator *(BigNum a, BigNum b)
		{
			// O - Optimization!
			if (b.Absolute > a.Absolute) {
				return b * a;
			}

			if (a.Positive ^ b.Positive) {
				var result = a.Absolute * b.Absolute;
				result.Positive = false;
				return result;
			}
			// -1 * -1 = 1 * 1
			// always positive=true
			var newNum = new BigNum();
			for (var i = 0; i <= b.Lenght; i++) {
				var aCopy = new BigNum(a).Absolute;
				aCopy.MultiplyByNumeral(b[i]);

				// multiply to 10 ^ i
				if (i > 0) {
					for (var j = 0; j < i; j++) {
						aCopy.Insert(0, 0);
					}
				}
				DeleteInsignificantZeros(aCopy);
				newNum += aCopy;
			}
			DeleteInsignificantZeros(newNum);
			return newNum;
		}

		public void MultiplyByNumeral(byte numeral) {
			for (var i = Lenght - 1; i >= 0; i--) {
				RecursiveMultiply(numeral, i);
			}
		}

		private void RecursiveMultiply(byte numeral, int index) {
			while (index >= number.Count)
			{
				Add(0);
			}
			// for (var i = number.Count - 1; i >= 0; i--) { }
			number[index] *= numeral;
			if (number[index] > 9)
			{
				byte nextAdd = (byte)(number[index] / 10);
				recursiveAdd(nextAdd, index + 1);
				number[index] = (byte)(number[index] % 10);
			}
			DeleteInsignificantZeros(this);
		} 
	}
}
