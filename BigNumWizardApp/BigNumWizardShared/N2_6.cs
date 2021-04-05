using System;
using System.Collections.Generic;
using System.Text;

namespace BigNumWizardShared
{
    public class N2_6
    {
        public static string NZER_N_B(BigNum n)
        {
            if (n != BigNum.Zero) return "yes";
            else return "no";
        }

        public static BigNum MUL_ND_N(BigNum number, byte D)
        {
            var ncopy = new BigNum(number);
            ncopy.MultiplyByNumeral(D);
            return ncopy;
        }

    }
}
