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

        public static Polynomial MUL_Pxk_P(int m, List<int> C, int k)
        {
            var polynom = new Polynomial(m, C);

            for (int i = 0; i < k; i++)
            {
                polynom.Odds.Add(0);
            }
            polynom.SeniorDegree = m + k;

            return polynom;
        }


    }

}
