using BigNumWizardShared;
using System;
using System.Collections.Generic;
using System.Text;

namespace BigNumWizardShared
{
    public class P4_5
    {

        public static int LED_P_Q(int m, List<int> C)
        {
            return C[0];
        }

        public static Polynomial MUL_Pxk_P(int m, List<BigFraction> C, BigNum k)
        {
            var polynom = new Polynomial(new BigNum(m.ToString()), C);

            for (BigNum i = BigNum.Zero; i < k; i += BigNum.One)
            {
                polynom.Odds.Add(new BigFraction(BigNum.Zero));
            }
            polynom.SeniorDegree = new BigNum(m.ToString()) + k;

            return polynom;
        }


    }

}
