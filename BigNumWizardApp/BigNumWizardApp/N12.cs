using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigNumWizardShared
{
    public class N12
    {
        public static BigNum DIV_NN_Dk(BigNum a, BigNum b)
        {
            if (Natural1_5.COM_NN_D(a, b) == 2 || Natural1_5.COM_NN_D(a, b) == 0)
                return a % b;
            else
                return b % a;
        }
    }
}