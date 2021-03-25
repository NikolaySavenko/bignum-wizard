using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigNumWizardShared
{
    public class N8_14
    {
        public static BigNum MUL_NN_N(BigNum a, BigNum b) //N-8 умножение натуральных чисел Швец Степан 0305 
        {
            return a * b;
        }

        /*
        public static BigNum LCM_NN_N(BigNum a, BigNum b) //N-14 нок натуральных чисел Швец Степан 0305 
        {
            BigNum res = new BigNum();
            res = DIV_NN_N(MUL_NN_N(a, b),GCF_NN_N(a, b)); //добавить имена классов
            return res;
        }
        */
    }
}
