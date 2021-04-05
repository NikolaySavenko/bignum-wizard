using System;
using System.Collections.Generic;
using System.Text;

namespace BigNumWizardShared
{
    public class Q1 
    {
        public static BigFraction RED_Q_Q(BigFraction fract) //Q-1 Сокращение дроби Петракова Марина 0305
        {
            BigNum abs_nom = Absolute.ABS_Z_N(fract.Nom);
            BigNum abs_denom = Absolute.ABS_Z_N(fract.Denom);
            BigNum gcf = N4_13.GCF_NN_N(abs_nom, abs_denom);
            BigNum new_nom = Z9.DIV_ZZ_Z(fract.Nom, gcf, out BigNum remainer0);
            BigNum new_denom = Z9.DIV_ZZ_Z(fract.Denom, gcf, out BigNum remainer1);
            BigFraction result = new BigFraction(new_nom, new_denom);
            return result;
        }
    }
}
