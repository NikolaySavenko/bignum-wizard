using System;
using System.Collections.Generic;
using System.Text;

namespace BigNumWizardShared
{
    public class N11
    {
        public static BigNum DIV_NN_N(BigNum A, BigNum B) // Частное от деления большего натурального числа на меньшее или равное натуральное с остатком(делитель отличен от нуля)
        {
            BigNum Q , R;
            if (A>=B)
            {
                Q = A / B; // целая часть
                R = A % B; // остаток
                return Q;
            }
            else
            {
                Q = B / A;
                R = B % A;
                return R;
            }
        }
    }
}
