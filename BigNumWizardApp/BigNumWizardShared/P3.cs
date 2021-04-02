using System;
using System.Collections.Generic;
using System.Text;

namespace BigNumWizardShared
{
    public class P3
    {

        public static Polynomial MUL_PQ_P(int m, List<BigFraction> C, BigFraction num)
        {
            var polynom = new Polynomial(m, C);
            for (int i = 0; i <= m; i++)
            {
                polynom.Odds[i] = Q5_7.MUL_QQ_Q(polynom.Odds[i], num);
            }

            return polynom;
        }


    }
}
