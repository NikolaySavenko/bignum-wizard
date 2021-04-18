using System;
using System.Collections.Generic;
using System.Text;

namespace BigNumWizardShared
{
    public class P3
    {

        public static Polynomial MUL_PQ_P(BigNum m, List<BigFraction> C, BigFraction num)
        {
            var polynom = new Polynomial(m, C);

            int n = m.ConvertToInt();
            for (int i = 0; i <= n; i++)
            {
                polynom.Odds[i] = Q5_7.MUL_QQ_Q(polynom.Odds[i], num);
            }

            return polynom;
        }


    }
}
