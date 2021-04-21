using System;
using System.Collections.Generic;
using System.Text;

namespace BigNumWizardShared
{
    public class Q6
    {
        public static BigFraction SUB_QQ_Q(BigFraction fir, BigFraction sec)    // Q-6, вычитание дробей, Иванов Артём 0305
        {
            if (fir.Denom != BigNum.Zero && sec.Denom != BigNum.Zero)
            {
                var result = fir - sec; // Получить несокращённую дробь-сумму
                result = Q1.RED_Q_Q(result);
                return result;
            }
            else
            {
                throw new Exception("На ноль делить нельзя!");
            }
        }
    }
}
