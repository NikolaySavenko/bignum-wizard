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
		public static BigNum One { get; } = new BigNum("1");
		//
		// Summary:
		//     Gets a value that represents the number negative one (-1).
		//
		// Returns:
		//     An BigNum whose value is negative one (-1).
		public static BigNum MinusOne { get; } = new BigNum("-1");
		//
		// Summary:
		//     Gets a value that represents the number 0 (zero).
		//
		// Returns:
		//     An BigNum whose value is 0 (zero).
		public static BigNum Zero { get; } = new BigNum("0");
		//
		// Summary:
		//     Gets a value that represents the number 10 (ten).
		//
		// Returns:
		//     An BigNum whose value is 10 (zero).
		public static BigNum Ten { get; } = new BigNum("10");
	}
}