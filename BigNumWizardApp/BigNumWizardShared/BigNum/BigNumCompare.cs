using System;
using System.Numerics;

namespace BigNumWizardShared
{
	public partial class BigNum
	{
		public static bool operator >(BigNum a, BigNum b) => a.CompareTo(b) > 0;

		public static bool operator >=(BigNum a, BigNum b) => a.CompareTo(b) >= 0;

		public static bool operator <(BigNum a, BigNum b) => a.CompareTo(b) < 0;

		public static bool operator <=(BigNum a, BigNum b) => a.CompareTo(b) <= 0;

		public static bool operator ==(BigNum a, BigNum b) => a.Equals(b);

		public static bool operator !=(BigNum a, BigNum b) => !a.Equals(b);

		// IComparable

		// TODO make this shit alike normal
		public int CompareTo(object obj)
		{
			if (obj == null)
			{
				return Positive ? 1 : -1;
			}

			var target = obj as BigNum;

			if (Positive && !target.Positive) return 1;
			else if (!Positive && target.Positive) return -1;

			while (Lenght < target.Lenght) Add(0);
			while (target.Lenght < Lenght) target.Add(0);

			// Len of a and b is equals
			for (var i = Lenght - 1; i >= 0; i--)
			{
				if (target[i] != this[i])
				{
					var compared = this[i].CompareTo(target[i]);
					DeleteInsignificantZeros(target, this);
					return Positive ? compared : compared * -1;
				}
			}
			DeleteInsignificantZeros(target, this);
			return 0;
		}

		// IEquatable

		public bool Equals(BigNum other)
		{
			// O - Optimization!
			if (Positive != other.Positive)
			{
				var zero = new BigNum();
				if (other.Absolute == zero && Absolute == zero) return true;
				else return false;
			}
			if (Lenght != other.Lenght) return false;

			for (var i = 0; i < Lenght; i++)
			{
				if (number[i] != other[i]) return false;
			}
			return true;
		}
	}
}