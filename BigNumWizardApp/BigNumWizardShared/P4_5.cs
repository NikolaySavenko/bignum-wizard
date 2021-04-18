using BigNumWizardShared;
using System;
using System.Collections.Generic;
using System.Text;

namespace BigNumWizardShared
{
    public class P4_5
    {

        public static BigFraction LED_P_Q(BigNum m, List<BigFraction> C)
        {
            return C[0];
        }

        public static Polynomial MUL_Pxk_P(BigNum m, List<BigFraction> C, BigNum k)
        {
            var polynom = new Polynomial(m, C);

            int n = k.ConvertToInt();
            for (int i = 0; i < n; i++)
            {
                polynom.Odds.Add(new BigFraction(BigNum.Zero));
            }
            polynom.SeniorDegree = m + k;

            return polynom;
        }


    }

}
