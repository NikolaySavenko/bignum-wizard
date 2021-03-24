using System;
using System.Collections.Generic;
using System.Text;

namespace BigNumWizardShared
{
    public class N2_6
    {
        public static string NZER_N_B(BigNum n)
        {
            if (n != new BigNum("0")) return "yes";
            else return "no";
        }

        public static int MUL_ND_N(int number, int x)
        {
            return number * x;
        }

    }
}
