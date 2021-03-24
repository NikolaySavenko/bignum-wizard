using System;
using System.Collections.Generic;
using System.Text;

namespace BigNumWizardShared
{
    class N3_N7
    {
        public static BigNum ADD_1N_N(BigNum number)
        {

            int k = number.Lenght - 1;
            while (k != -1)
            {
                if (number[k] < 9)
                {
                    number[k]++;
                    k = -1;
                }
                else
                {
                    number[k] = 0;
                    k--;
                }
            }
            if (number[0] == 0)
            {
                number.Insert(0, 1);
            }
            return number;
        }



        public static BigNum MUL_Nk_N(BigNum a, int k)
        {
            for (int i = 0; i < k; i++)
            {
                a.Insert(a.Lenght,0);
            }
            return a;
        }
    }
}
