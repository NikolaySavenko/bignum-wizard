using System;
using System.Numerics;
using System.Collections.Generic;
using System.Collections;

namespace BigNumWizardShared
{
	public partial class BigNum
	{
		// IEnumerable

		public IEnumerator<byte> GetEnumerator() => number.GetEnumerator();

		IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
	}
}