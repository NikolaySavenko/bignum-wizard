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
			foreach (var element in reverted) {
				number.Add((byte)Char.GetNumericValue(element));
			}
		}

		public BigNum(BigNum original) {
			number = new List<byte>();
			foreach (var n in original.number) {
				number.Add(n);
			}
			Positive = original.Positive;
		}

		public BigNum(string longNumber, bool positive) : this(longNumber) {
			Positive = positive;
		}

		public void Add(byte smallNum) => number.Insert(number.Count, smallNum);
		public void Insert(int index, byte value) => number.Insert(index, value);

		// only when abs A > abs B
		public static BigNum operator +(BigNum a, BigNum b) {
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

			for (var i = 0; i < b.Lenght; i++) {
				newNum.recursiveAdd(b[i], i);
			}
			return newNum;
		}

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
			if (b.Absolute > a.Absolute) { 
				BigNum val = b.Absolute - a.Absolute;
				val.Positive = !a.Positive;
				return val;
			}
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
			
			while (a.Lenght < b.Lenght) a.Add(0);
			while (b.Lenght < a.Lenght) b.Add(0);
			BigNum newNum = new BigNum(a);
			// ITS A TRAP!
			for (var i = 0; i < b.Lenght; i++) newNum.recursivePick(b[i], i);

			// deleting Insignificant zeros
			for (var i = newNum.Lenght - 1; i > 0; i--)
			{
				if (newNum.number[i] == 0) newNum.number.RemoveAt(i);
				else break;
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
			while (index >= number.Count)
			{
				Add(0);
			}
			// for (var i = number.Count - 1; i >= 0; i--) { }
			number[index] += add;
			if (number[index] > 9) {
				byte nextAdd = (byte)(number[index] / 10);
				recursiveAdd(nextAdd, index + 1);
				number[index] = (byte)(number[index] % 10);
			}
		}

		// TODO move this shit (fukin again shit) to this[int key] set
		private void recursivePick(byte pick, int index)
		{
			// TODO check index + 1
			while (number.Count < index + 1)
			{
				number.Add(0);
			}
			if (number[index] < pick) {
				recursivePick(1, index + 1);
				number[index] += 10;
			}
			number[index] -= pick;
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
				sb.Insert(0, enumerator.Current);
			}
			if (!bNum.Positive) sb.Insert(0, "-");
			return sb.ToString();
		}

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
			if (obj == null) { 
				return Positive ? 1 : -1;
			}
			
			var target = obj as BigNum;
			// O - Optimization!
			if (Lenght != target.Lenght) return Lenght.CompareTo(Lenght);

			if (Positive && !target.Positive) return 1;
			else if (!Positive && target.Positive) return -1;

			// Len of a and b is equals
			for (var i = Lenght - 1; i >= 0; i--) {
				if (target[i] != this[i]) {
					var compared = this[i].CompareTo(target[i]);
					return Positive ? compared : compared * -1;
				}
			}
			return 0;
		}

		// IEquatable

		public bool Equals(BigNum other)
		{
			// O - Optimization!
			if (Positive != other.Positive) {
				var zero = new BigNum();
				if (other.Absolute == zero && Absolute == zero) return true;
				else return false;
			}
			if (Lenght != other.Lenght) return false;

			for (var i = 0; i < Lenght; i++) {
				if (number[i] != other[i]) return false;
			}
			return true;
		}
	}
}
