using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigNumWizardShared
{
    public class Natural
    {
        public static BigNum MUL_NN_N(List<byte> a, List<byte> b)
        {
            BigNum res = new BigNum();
            for (int i = 0, len = b.Count; i < len; i++)
            {
                res = Add.ADD_NN_N(MultyTen.MUL_Nk_N(Multy.MUL_ND_N(a, b[len - i - 1]), i), res); //добавить имена классов
            }
            return res;
        }

    }
