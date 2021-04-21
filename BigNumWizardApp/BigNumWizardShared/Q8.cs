using System;

namespace BigNumWizardShared
{
    public class Q8
    {
        public static BigFraction DIV_QQ_Q(BigFraction first, BigFraction second) //Q-8 Деление дробей Петракова Марина 0305 
        {
            BigFraction fraction;
            if (first.Denom != BigNum.Zero && second.Nom != BigNum.Zero && second.Denom != BigNum.Zero)
            {
                fraction = first / second;
                fraction = Q1.RED_Q_Q(fraction);
            }
            else
            {
                throw new Exception("На ноль делить нельзя!");
            }
            return fraction;
        }
    }
}
