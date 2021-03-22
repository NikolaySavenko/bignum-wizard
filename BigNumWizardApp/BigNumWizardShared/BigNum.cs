using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BigNumWizardShared
{
	public class BigNum : IEnumerable<byte>, IComparable, IEquatable<BigNum>
	{
		private List<byte> number;

		public bool Positive { get; private set; }

		public BigNum Absolute
		{
			get
			{
				var absNum = new BigNum();
				absNum.number = number;
				absNum.Positive = true;
				return absNum;
			}
		}

		public BigNum() : this("0") { }

		public BigNum(string longNumber) {
			Positive = true;
			if (longNumber[0] == '-')
			{
				Positive = false;
				longNumber = longNumber.Remove(0, 1);
			}
			else if (longNumber[0] == '+') longNumber = longNumber.Remove(0, 1);
			number = new List<byte>();
			foreach (var element in longNumber) {
				number.Add((byte)Char.GetNumericValue(element));
			}
			
		}

		public BigNum(string longNumber, bool positive) : this(longNumber) {
			Positive = positive;
		}

		public void Add(byte smallNum) => number.Insert(0, smallNum);

		// only when abs A > abs B
		public static BigNum operator +(BigNum a, BigNum b) {
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
			BigNum newNum = new BigNum();
			while (a.Lenght < b.Lenght) a.Add(0);
			while (b.Lenght < a.Lenght) b.Add(0);
			for (var i = a.Lenght - 1; i >= 0; i--) {
				newNum.recursiveAdd(a[i], i);
				newNum.recursiveAdd(b[i], i);
			}
			return newNum;
		}

		// only when abs A > abs B
		public static BigNum operator -(BigNum a, BigNum b)
		{
			// TODO rewrite this shit to normal XOR and other stuff
			if (a.Positive && !b.Positive) {
				return a.Absolute + b.Absolute;
			} else if (!a.Positive && b.Positive) {
				BigNum val = a.Absolute + b.Absolute;
				val.Positive = false;
				return val;
			} else if (!a.Positive && !b.Positive) {
				BigNum val = a.Absolute - b.Absolute;
				val.Positive = false;
				return val;
			}
			// a and b is positive
			BigNum newNum = new BigNum();
			while (a.Lenght < b.Lenght) a.Add(0);
			while (b.Lenght < a.Lenght) b.Add(0);
			for (var i = a.Lenght - 1; i >= 0; i--)
			{
				newNum.recursiveAdd(a[i], i);
				newNum.recursivePick(b[i], i);
			}
			return newNum;
		}

		public byte this[int key] {
			get {
				if (key >= number.Count) return 0;
				return number[key];
			}

			set {
				while (number.Count < key + 1) { 
					number.Add(0); 
				}
				number[key] = value;
			}
		}
		// TODO move this shit (fukin shit) to this[int key] set
		private void recursiveAdd(byte add, int index) {
			while (number.Count < index + 1)
			{
				number.Add(0);
			}
			// for (var i = number.Count - 1; i >= 0; i--) { }
			number[index] += add;
			if (number[index] > 9) {
				byte nextAdd = (byte)(number[index] / 10);
				recursiveAdd((byte)(number[index] % 10), index + 1);
				number[index] = nextAdd;
			}
		}

		// TODO move this shit (fukin again shit) to this[int key] set
		private void recursivePick(byte pick, int index)
		{
			while (number.Count < index + 1)
			{
				number.Add(0);
			}
			if (number[index] < pick) {
				recursivePick(1, index + 1);
				pick -= 10;
			}
			number[index] -= pick;
			if (index > 0 && number[index] == 0) number.RemoveAt(index);
		}

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
				sb.Append(enumerator.Current.ToString());
			}
			return sb.ToString();
		}

		// TODO add negative support!
		public static bool operator >(BigNum a, BigNum b) => a.CompareTo(b) > 0;

		public static bool operator >=(BigNum a, BigNum b) => a.CompareTo(b) >= 0;

		public static bool operator <(BigNum a, BigNum b) => a.CompareTo(b) < 0;

		public static bool operator <=(BigNum a, BigNum b) => a.CompareTo(b) <= 0;

		public static bool operator ==(BigNum a, BigNum b) => a.Equals(b);

		public static bool operator !=(BigNum a, BigNum b) => !a.Equals(b);
		// length... Nikolay... fukin idiot...
		public int Lenght { get => number.Count; }

		// IEnumerable

		public IEnumerator<byte> GetEnumerator() => number.GetEnumerator();

		IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

		// IComparable

		// TODO make this shit alike normal
		public int CompareTo(object obj)
		{
			if (obj == null) return 1;

			var target = obj as BigNum;
			var thisEnumerator = GetEnumerator();
			var targetEnumerator = target.GetEnumerator();
			while (thisEnumerator.Current == targetEnumerator.Current) {
				thisEnumerator.MoveNext();
				targetEnumerator.MoveNext();
			}
			var compared = thisEnumerator.Current.CompareTo(targetEnumerator.Current);
			return compared;
		}

		// IEquatable

		public bool Equals(BigNum other)
		{
			// O - Optimization!
			if (Positive != other.Positive) return false;
			if (Lenght != other.Lenght) return false;

			for (var i = 0; i < Lenght; i++) {
				if (number[i] != other[i]) return false;
			}
			return true;
		}
	}
}
