using System;
using System.Collections.Generic;
using System.Text;

namespace BigNumWizard
{
    public class N12
    {
        public static void DIV_NN_Dk(BigNum a, BigNum b)
        {
            if (Natural1_5.COM_NN_D(a, b) == 2 || Natural1_5.COM_NN_D(a, b) == 0)
                return a % b;
            else if (Natural1_5.COM_NN_D(a, b) == 1)
                return b % a;
        }
    }
}