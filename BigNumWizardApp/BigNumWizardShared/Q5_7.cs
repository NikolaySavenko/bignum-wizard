using System;

namespace BigNumWizardShared
{
    public class Q5_7
    {
        public static BigFraction ADD_QQ_Q(BigFraction fir, BigFraction sec)    // Q-5, сложение дробей, Осипцов Никита 0305
        {
            if (fir.Denom != BigNum.Zero && sec.Denom != BigNum.Zero)
            {
                var result = fir + sec; // Получить несокращённую дробь-сумму
                result = Q1.RED_Q_Q(result);
                return result;
            }
            else
                throw new Exception("На ноль делить нельзя!");
        }

        public static BigFraction MUL_QQ_Q(BigFraction fir, BigFraction sec) // Q-7, умножение дробей, Осипцов Никита 0305
        {
            if (fir.Denom != BigNum.Zero && sec.Denom != BigNum.Zero)
            {
                var fraction = fir * sec;
                fraction = Q1.RED_Q_Q(fraction);
                return fraction;
            }

            else
                throw new Exception("На ноль делить нельзя!");
        }
    }
}
