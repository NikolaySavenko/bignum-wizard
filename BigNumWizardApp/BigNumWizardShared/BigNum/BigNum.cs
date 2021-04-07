using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace BigNumWizardShared
{
	[DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
	public partial class BigNum : IEnumerable<byte>, IComparable, IEquatable<BigNum>
	{
		private List<byte> number;

		public bool Positive { get; private set; }

		public BigNum Absolute
		{
			get => new BigNum
			{
				number = number,
				Positive = true
			};
		}

		public BigNum() : this("0") { }

		public BigNum(string longNumber)
		{
			Positive = true;
			number = new List<byte>();
			longNumber = String.IsNullOrEmpty(longNumber) ? "0" : longNumber;

			if (longNumber[0] == '-')
			{
				Positive = false;
				longNumber = longNumber.Remove(0, 1);
			}
			else if (longNumber[0] == '+') longNumber = longNumber.Remove(0, 1);

			char[] array = longNumber.ToCharArray();
			Array.Reverse(array);
			var reverted = String.Concat<char>(array);
			foreach (var element in reverted)
			{
				number.Add((byte)Char.GetNumericValue(element));
			}
		}

		public BigNum(BigNum original)
		{
			number = new List<byte>();
			foreach (var n in original.number)
			{
				number.Add(n);
			}
			Positive = original.Positive;
		}

		public BigNum(string longNumber, bool positive) : this(longNumber)
		{
			Positive = positive;
		}

		public void Add(byte smallNum) => number.Insert(number.Count, smallNum);
		public void Insert(int index, byte value) => number.Insert(index, value);
		// length... Nikolay... fukin idiot...
		public int Lenght { get => number.Count; }

		public static void DeleteInsignificantZeros(ref BigNum num)
		{
			// deleting Insignificant zeros
			for (var i = num.Lenght - 1; i > 0; i--)
			{
				if (num.number[i] == 0) num.number.RemoveAt(i);
				else break;
			}
		}

		public static void DeleteInsignificantZeros(params BigNum[] nums)
		{
			for (int i = 0; i < nums.Length; i++) {
				BigNum num = nums[i];
				DeleteInsignificantZeros(ref num);
			}
		}

		public byte this[int key]
		{
			get
			{
				if (key >= number.Count) return 0;
				return number[key];
			}

			set
			{
				while (number.Count < key + 1)
				{
					number.Add(0);
				}
				number[key] = value;
			}
		}
	}
}
