using System;
using System.Collections.Generic;
using System.Text;

namespace BigNumWizardShared
{
    public class Natural1_5
    {
        public static int COM_NN_D(BigNum fir, BigNum sec)  //comparison numb(1 is <; 0 is =; 2 is >) Kabanov 0305 
        {
            if (fir > sec)
                return 2;
            else
                if (fir < sec)
                    return 1;
                else 
                    return 0;
        }

        public static BigNum SUB_NN_N(BigNum fir, BigNum sec) /*Subtraction from the first large natural 
                                                                    number of the second smaller or equal Kabanoм 0305*/
        {
            if (COM_NN_D(fir, sec) == 2 || COM_NN_D(fir, sec) == 0)
                    return fir - sec;
                else
                    return sec - fir;
        }
    }
}
