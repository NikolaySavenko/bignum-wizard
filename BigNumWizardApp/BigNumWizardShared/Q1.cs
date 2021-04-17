using System;

namespace BigNumWizardShared
{
    public class Q1
    {
        public static BigFraction RED_Q_Q(BigFraction fract) //Q-1 Сокращение дроби Петракова Марина 0305
        {
            BigFraction result;
            if (fract.Denom != BigNum.Zero)
            {
                BigNum gcf = N4_13.GCF_NN_N(fract.Nom, fract.Denom);
                BigNum new_nom = Z9.DIV_ZZ_Z(fract.Nom, gcf, out _);
                BigNum new_denom = Z9.DIV_ZZ_Z(fract.Denom, gcf, out _);
                result = new BigFraction(new_nom, new_denom);
                if (fract.Positive == false)
                {
                    result = result.GetOppositeSigned();
                }
            }
            else
            {
                throw new Exception("На ноль делить нельзя!");
            }
            
            return result;
        }
    }
}
