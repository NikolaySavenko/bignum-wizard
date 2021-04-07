using System;
using System.Collections.Generic;
using System.Text;

namespace BigNumWizardShared
{
    public class Q1 
    {
        public static BigFraction RED_Q_Q(BigFraction fract) //Q-1 Сокращение дроби Петракова Марина 0305
        {
            BigNum gcf = N4_13.GCF_NN_N(fract.Nom, fract.Denom);
            BigNum new_nom = Z9.DIV_ZZ_Z(fract.Nom, gcf, out BigNum remainer0);
            BigNum new_denom = Z9.DIV_ZZ_Z(fract.Denom, gcf, out BigNum remainer1);
            BigFraction result = new BigFraction(new_nom, new_denom);
            if (fract.Positive == false)
            {
                result = result.GetOppositeSigned();
            }
            return result;
        }
    }
}
