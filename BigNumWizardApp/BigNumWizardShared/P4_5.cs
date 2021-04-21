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

            for (BigNum i = BigNum.Zero; i < k; i += BigNum.One)
            {
                polynom.Odds.Add(new BigFraction(BigNum.Zero));
            }
            polynom.SeniorDegree = m + k;

            while (polynom.Odds[0].Nom == BigNum.Zero && polynom.Odds.Count > 1)
            {
                polynom.Odds.RemoveAt(0);
            }

            var max = new BigNum((polynom.Odds.Count - 1).ToString());
            polynom.SeniorDegree = max;

            return polynom;
        }


    }

}
