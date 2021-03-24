using System;
using System.Collections.Generic;
using System.Text;

namespace BigNumWizardShared
{
    public class Rational
    {
        public static BigNum TRANS_Q_Z(BigNum fir, BigNum sec)
        {
            if (sec == new BigNum("1"))
            {
                return fir;
            }
            else
            {
                return sec;
                // TODO make that shit better (example: 12/3)
            }
        }
    }
}
