using System;
using System.Collections.Generic;
using System.Text;

namespace BigNumWizardShared
{
    public class Q2_3
    { 
        public static string INT_Q_B(BigNum num, BigNum den)  //Проверка на целое, если рациональное число является целым, то «да», иначе «нет» 0305 Брацун Владимир
        {
            if (num % den == BigNum.Zero)
                return "Yes";
            else
                return "No";
        }

        public static BigFraction TRANS_Z_Q(BigNum num, BigNum ent)  //Преобразование целого в дробное 0305 Брацун Владимир
        {
            return new BigFraction(num*ent, ent);
        }
    }
}