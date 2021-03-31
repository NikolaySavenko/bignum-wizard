using System;
using System.Collections.Generic;
using System.Text;

namespace BigNumWizardShared
{
    class N9
    {
       public static BigNum SUB_NDN_N(BigNum A, BigNum B, byte D) // N-9 Соловьева Елизавета 0310
        {
            if (Natural1_5.COM_NN_D(B ,N2_6.MUL_ND_N(A, D)) == 2 || Natural1_5.COM_NN_D(B, N2_6.MUL_ND_N(A, D)) == 0) //A*D <= B
            {
                return B - N2_6.MUL_ND_N(A, D); //B -A*D
            }
            else if (Natural1_5.COM_NN_D(A, N2_6.MUL_ND_N(B, D)) == 2 || Natural1_5.COM_NN_D(A, N2_6.MUL_ND_N(A, D)) == 0) //B*D <= A
            {
                return A - N2_6.MUL_ND_N(B, D); //A - B*D
            }
            else
            {
                throw new Exception("Something went wrong");
            }
        }
    }
}
