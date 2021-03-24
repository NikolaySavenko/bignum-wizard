using System;
using System.Collections.Generic;
using System.Text;

namespace BigNumWizardShared
{
    class N9
    {
       public static BigNum SUB_NDN_N(BigNum A, BigNum B, int D) // N-9 Соловьева Елизавета 0310
        {
            if (COM_NN_D(MUL_ND_N(A, D), B) == 2 || COM_NN_D(MUL_ND_N(A, D), B) == 0) //A*D >= B
                return MUL_ND_N(A, D) - B; //A*D - B
            else if (COM_NN_D(MUL_ND_N(B, D), A) == 2 || COM_NN_D(MUL_ND_N(A, B), A) == 0) //B*D >= A
                return MUL_ND_N(B, D) - A; //B*D - A
        }
    }
}
