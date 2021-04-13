using System;
using System.Collections.Generic;
using System.Text;

namespace BigNumWizardShared
{
    public class P9 //Shvets
    {
        public static Polynomial DIV_PP_P(int m1, List<BigFraction> C1, int m2, List<BigFraction> C2)
        {
            int d = m1 - m2;

            
            var resultOdds = new List<BigFraction>();

            for (int i = 0; i < d + 1; i++)
            {
                resultOdds.Add(Q8.DIV_QQ_Q(C1[0], C2[0]));

                for (int j = 0; j < m2; j++)
                {
                    C1[j] = Q6.SUB_QQ_Q(C1[j], Q5_7.MUL_QQ_Q(C2[j], resultOdds[i]));
                }
                C1.RemoveAt(0);
            }

            if (d < 0)
            {
                d = 0;
                resultOdds.Add(new BigFraction(BigNum.Zero));
            }

            var resultSeniorDegree = new BigNum(d.ToString());
            var resultPolynom = new Polynomial(resultSeniorDegree, resultOdds);

            return resultPolynom;
        }
    }
}
