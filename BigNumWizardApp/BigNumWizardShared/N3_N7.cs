﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BigNumWizardShared
{
    class N3_N7
    {
        public static BigNum ADD_1N_N(BigNum number) //N-3 добавление единицы к нат. числу Петракова Марина 0305
        {
            number += new BigNum("1");
            return number;
        }


        public static BigNum MUL_Nk_N(BigNum number, BigNum k) //N-7 умножение нат.числа на 10^k Петракова Марина 0305
        {
            for (BigNum i=new BigNum("0"); i < k; i+=new BigNum("1"))
            {
                number.Insert(number.Lenght,0);
            }
            return number;
        }
    }
}
