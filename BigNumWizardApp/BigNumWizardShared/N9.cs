using System;
using System.Collections.Generic;
using System.Text;

namespace BigNumWizardShared
{
    class N9
    {
       public static BigNum SUB_NDN_N(BigNum A, BigNum B, byte D) // N-9 Соловьева Елизавета 0310
        {
            if (Natural1_5.COM_NN_D(N2_6.MUL_ND_N(A, D), B) == 2 || Natural1_5.COM_NN_D(N2_6.MUL_ND_N(A, D), B) == 0) //A*D >= B
            {
                return N2_6.MUL_ND_N(A, D) - B; //A*D - B
            }
            else if (Natural1_5.COM_NN_D(N2_6.MUL_ND_N(B, D), A) == 2 || Natural1_5.COM_NN_D(N2_6.MUL_ND_N(A, D), A) == 0) //B*D >= A
            {
                return N2_6.MUL_ND_N(B, D) - A; //B*D - A
            }
        }
    }
}
