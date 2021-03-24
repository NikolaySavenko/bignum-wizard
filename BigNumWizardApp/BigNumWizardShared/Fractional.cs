using System;
using System.Collections.Generic;
using System.Text;

namespace BigNumWizardShared
{
    class Fractional
    {
        // TODO add % in BigNum
        static string INT_Q_B(int num, int den)  //Проверка на целое, если рациональное число является целым, то «да», иначе «нет»
        {
            if (num % den == 0)
                return ("Yes");
            else
                return ("No");
        }

        static BigNum TRANS_Z_Q(BigNum num, BigNum ent)  //Преобразование целого в дробное
        {
            return num;
            //make that shit better in future
        }
    }
}