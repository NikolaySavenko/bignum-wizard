using System;
using System.Numerics;

namespace BigNumWizardShared
{
	public partial class BigNum
	{
		//
		// Summary:
		//     Gets a value that represents the number one (1).
		//
		// Returns:
		//     An object whose value is one (1).
		private static readonly BigNum _one = new BigNum("1");
		public static BigNum One { get => _one; }
		//
		// Summary:
		//     Gets a value that represents the number negative one (-1).
		//
		// Returns:
		//     An BigNum whose value is negative one (-1).
		private static readonly BigNum _minusOne = new BigNum("-1");
		public static BigNum MinusOne { get => _minusOne; }
		//
		// Summary:
		//     Gets a value that represents the number 0 (zero).
		//
		// Returns:
		//     An BigNum whose value is 0 (zero).
		private static readonly BigNum _zero = new BigNum("0");
		public static BigNum Zero { get => _zero; }
		//
		// Summary:
		//     Gets a value that represents the number 10 (ten).
		//
		// Returns:
		//     An BigNum whose value is 10 (ten).
		private static readonly BigNum _ten = new BigNum("10");
		public static BigNum Ten { get => _ten; }
	}
}