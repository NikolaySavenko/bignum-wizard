using BigNumWizardShared;
using System;
using System.Collections.Generic;
using System.Text;

namespace BigNumWizard
{
    public class N10
    {
        public static BigNum DIV_NN_Dk(BigNum num1, BigNum num2) // Вычисление первой цифры деления большего натурального на меньшее, домноженное на 10^k,где k - номер позиции этой цифры (номер считается с нуля) 0305 Брацун
        {
            BigNum frstnum;
            BigNum count;
            if (Natural1_5.COM_NN_D(num1, num2) == 2)
            {
                frstnum = num1 % num2;
                for (count = new BigNum("0"); count > new BigNum("9"); count = count + new BigNum("1"))
                    frstnum = frstnum % new BigNum("10");
                return N3_N7.MUL_Nk_N(num2, count);
            }
            else if (Natural1_5.COM_NN_D(num1, num2) == 1)
            {
                frstnum = num2 % num1;
                for (count = new BigNum("0"); count > new BigNum("9"); count = count + new BigNum("1"))
                    frstnum %= new BigNum("10");
                return N3_N7.MUL_Nk_N(frstnum, count);
            }
            else return new BigNum("0"); 
        }
    }
}