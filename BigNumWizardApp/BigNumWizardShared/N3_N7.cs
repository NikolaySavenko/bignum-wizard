using System;
using System.Collections.Generic;
using System.Text;

namespace BigNumWizardShared
{
    public class N3_N7
    {
        public static BigNum ADD_1N_N(BigNum number) //N-3 добавление единицы к нат. числу Петракова Марина 0305
        {
            BigNum res_number = number + BigNum.One;
            return res_number;
        }

        public static BigNum MUL_Nk_N(BigNum number, int k) //N-7 умножение нат.числа на 10^k Петракова Марина 0305
        {
            for (int i=0; i<k; i++)
            { 
                number.Insert(0,0);
            }
            return number;
        }
    }
}
