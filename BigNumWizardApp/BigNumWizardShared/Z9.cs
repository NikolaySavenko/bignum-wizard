﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BigNumWizardShared
{
    public class Z9
    {
        public static BigNum DIV_ZZ_Z(BigNum A, BigNum B, out BigNum remainer) // Частное от деления целого на целое (делитель отличен от нуля) Соловьева 0310
        {
            if (z2_3.POZ_Z_D(A) != 0 || B > A)
            {
                BigNum C;
                C = N11.DIV_NN_N(A, B, out remainer);
                return C;
                //return A / B;
            }
            else if (z2_3.POZ_Z_D(B) != 0 || A > B)
            {
                BigNum C;
                C = N11.DIV_NN_N(B, A, out remainer);
                return C;
            }
                //return B / A;
            else
            {
                throw new Exception("Something went wrong");
            }
        }

    }
}
