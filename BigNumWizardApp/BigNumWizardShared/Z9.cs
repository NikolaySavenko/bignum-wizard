using System;
using System.Collections.Generic;
using System.Text;

namespace BigNumWizardShared
{
    public class Z9
    {
        public static BigNum DIV_NN_N(BigNum A, BigNum B) // Частное от деления целого на целое (делитель отличен от нуля) Соловьева 0310
        {
            if (z2_3.POZ_Z_D(A) != 0 || B > A)
                return A / B;
            else if (z2_3.POZ_Z_D(B) != 0 || A > B)
                return B / A;
            else
            { 
                throw new Exception("Something went wrong");
            }
        }

    }
}
