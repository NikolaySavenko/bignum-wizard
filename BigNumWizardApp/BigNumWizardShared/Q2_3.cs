﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BigNumWizardShared
{
    public class Q2_3
    { 
        public static string INT_Q_B(int num, int den)  //Проверка на целое, если рациональное число является целым, то «да», иначе «нет» 0305 Брацун Владимир
        {
            if (num % den == 0)
                return ("Yes");
            else
                return ("No");
        }

        public static BigNum TRANS_Z_Q(BigNum num, BigNum ent)  //Преобразование целого в дробное 0305 Брацун Владимир
        {
            return num;
            //make that shit better in future
        }
    }
}