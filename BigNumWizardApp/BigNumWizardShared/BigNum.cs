using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BigNumWizardShared
{
	public class BigNum : IEnumerable<byte>, IComparable
	{
		private List<byte> number;

		public BigNum() : this("0") { }

		public BigNum(string longNumber) {
			number = new List<byte>();
			foreach (var element in longNumber) {
				number.Add((byte)Char.GetNumericValue(element));
			}
		}

		public void Add(byte smallNum) => number.Insert(0, smallNum);

		public static BigNum operator +(BigNum a, BigNum b) {
			BigNum newNum = new BigNum();
			while (a.Lenght < b.Lenght) a.Add(0);
			while (b.Lenght < a.Lenght) b.Add(0);
			for (var i = a.Lenght - 1; i >= 0; i--) {
				newNum.recursiveAdd(a[i], i);
				newNum.recursiveAdd(b[i], i);
			}
			return newNum;
		}

		public static BigNum operator -(BigNum a, BigNum b)
		{
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

		public static bool operator ==(BigNum a, BigNum b)
		{
			return a.number.Equals(b);
		}

		public static bool operator !=(BigNum a, BigNum b)
		{
			return !a.number.Equals(b);
		}

		public int Lenght { get => number.Count; }

		// IEnumerable

		public IEnumerator<byte> GetEnumerator() => GetEnumerator();

		IEnumerator IEnumerable.GetEnumerator() => number.GetEnumerator();

		// IComparable

		// TODO make this shit alike normal
		public int CompareTo(object obj)
		{
			return Lenght.CompareTo(obj);
		}
	}
}
