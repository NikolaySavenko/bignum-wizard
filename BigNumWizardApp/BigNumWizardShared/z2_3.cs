using System;
using System.Collections.Generic;
using System.Text;

namespace BigNumWizardShared
{
    public class z2_3
    {
		public static int POZ_Z_D(BigNum n)
		{
			if (n > new BigNum("0"))
			{
				return 2;
			}
			else if (n == new BigNum("0"))
			{
				return 0;
				//return n.compareTo(new BigNum("0"))

			}
			else return 1;
		}

		public static BigNum MUL_ZM_Z(BigNum n)
		{
			return new BigNum("0") - n;
		}
	}
}
