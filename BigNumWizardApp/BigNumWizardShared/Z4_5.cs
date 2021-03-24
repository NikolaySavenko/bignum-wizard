using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigNumWizardShared
{
    public class Z4_5
    {
        public static BigNum TRANS_N_Z(BigNum a) //Z-4 преобразование натурального в целое Швец Степан 0305
        {
            BigNum res = new BigNum();
            res = a;
            return res;
        }
        public static BigNum TRANS_Z_N(BigNum a) //Z-5 преобразование целое в натуральное Швец Степан 0305
        {
            //добавить: провеку, является ли число положительным if (a.Positive) и в блоке else добавить обработку исключений, если оно таковым не является

            BigNum res = new BigNum();
            res = a;
            return res;
        }
    }
}
