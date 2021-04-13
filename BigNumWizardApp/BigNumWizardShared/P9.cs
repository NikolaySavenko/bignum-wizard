using System;
using System.Collections.Generic;
using System.Text;

namespace BigNumWizardShared
{
    public class P9 //Shvets
    {
        public static Polynomial DIV_PP_P(BigNum m1, List<BigFraction> C1, BigNum m2, List<BigFraction> C2)
        {
            BigNum d = m1 - m2;

            
            var resultOdds = new List<BigFraction>();

            for (var i = BigNum.Zero; i < d + BigNum.One; i = i + BigNum.One)
            {
                resultOdds.Add(Q8.DIV_QQ_Q(C1[0], C2[0]));

                for (var j = BigNum.Zero; j < m2; j = j + BigNum.One)
                {
                    C1[j.ConvertToInt()] = Q6.SUB_QQ_Q(C1[j.ConvertToInt()], Q5_7.MUL_QQ_Q(C2[j.ConvertToInt()], resultOdds[i.ConvertToInt()]));
                }
                C1.RemoveAt(0);
            }

            if (d < BigNum.Zero)
            {
                d = BigNum.Zero;
                resultOdds.Add(new BigFraction(BigNum.Zero));
            }

            var resultSeniorDegree = d;
            var resultPolynom = new Polynomial(resultSeniorDegree, resultOdds);

            return resultPolynom;
        }
    }
}
