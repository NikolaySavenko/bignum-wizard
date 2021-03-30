using System;
using System.Collections.Generic;
using System.Text;

namespace BigNumWizardShared
{
    public class N11
    {
        public static BigNum DIV_NN_N(BigNum A, BigNum B, out BigNum remainer) // Частное от деления большего натурального числа на меньшее или равное натуральное с остатком(делитель отличен от нуля)
        {
            return A.Divide(B, out remainer);
        }
    }
}
