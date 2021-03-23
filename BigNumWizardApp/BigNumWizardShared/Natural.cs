using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigNumWizardShared
{
    public class Natural
    {
        public static BigNum MUL_NN_N(BigNum a, BigNum b) //умножение натуральных чисел Швец Степан 0305
        {
            BigNum res = new BigNum();
            for (int i = 0, len = b.Lenght; i < len; i++)
            {
                res = ADD_NN_N(MUL_Nk_N(MUL_ND_N(a, b[len - i - 1]), i), res); //добавить имена классов
            }
            return res;
        }

        public static BigNum LCM_NN_N(BigNum a, BigNum b) //нок натуральных чисел Швец Степан 0305
        {
            BigNum res = new BigNum();
            res = DIV_NN_N(MUL_NN_N(a, b),GCF_NN_N(a, b)); //добавить имена классов
            return res;
        }
    }
}
