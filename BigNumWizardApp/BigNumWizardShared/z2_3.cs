using System;
using System.Collections.Generic;
using System.Text;

namespace BigNumWizardShared
{
    public class z2_3
    {
		public static int POZ_Z_D(BigNum n)
		{
			if (n > BigNum.Zero)
			{
				return 2;
			}
			else if (n == BigNum.Zero)
			{
				return 0;
				//return n.compareTo(BigNum.Zero)

			}
			else return 1;
		}

		public static BigNum MUL_ZM_Z(BigNum n)
		{
			return BigNum.Zero - n;
		}
	}
}
