using System;
using System.Collections.Generic;
using System.Text;

namespace BigNumWizardShared
{
    public class Rational
    {
        public static BigNum TRANS_Q_Z(BigNum fir, BigNum sec)  // Q-4 Преобразование дробного в целое (если знаменатель равен 1) Иванов Артём 0305
        {
            if (sec != BigNum.Zero)
            {
                if (sec == BigNum.One)
                {
                    return fir;
                }
                else
                {
                    return sec;
                    // TODO make that shit better (example: 12/3)
                }
            }
            else
            {
                throw new Exception("На ноль делить нельзя!");
            }
        }
    }
}
