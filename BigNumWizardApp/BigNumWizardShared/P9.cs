using System;
using System.Collections.Generic;

namespace BigNumWizardShared
{
    public class P9 //P-9 частное от деления многочлена на многочлен при делении с остатком Швец 0305
    {
        public static Polynomial DIV_PP_P(BigNum m1, List<BigFraction> C1, BigNum m2, List<BigFraction> C2)
        {
            Polynomial resultPolynom;

            if (m2 != BigNum.Zero || C2[0].Nom != BigNum.Zero)
            {
                var resultSeniorDegree = m1 - m2;
                var resultOdds = new List<BigFraction>();

                var N = C1.GetRange(0, C1.Count);

                for (var i = BigNum.Zero; i < resultSeniorDegree + BigNum.One; i = i + BigNum.One)
                {
                    resultOdds.Add(Q8.DIV_QQ_Q(N[0], C2[0]));

                    int n = m2.ConvertToInt();
                    for (int j = 0; j < n + 1; j++)
                    {
                        N[j] = Q6.SUB_QQ_Q(N[j], Q5_7.MUL_QQ_Q(C2[j], resultOdds[i.ConvertToInt()]));
                    }
                    N.RemoveAt(0);
                }

                if (resultSeniorDegree < BigNum.Zero)
                {
                    resultSeniorDegree = BigNum.Zero;
                    resultOdds.Add(new BigFraction(BigNum.Zero));
                }

                resultPolynom = new Polynomial(resultSeniorDegree, resultOdds);
            }
            else
            {
                throw new Exception("На ноль делить нельзя!");
            }

            return resultPolynom;
        }
    }
}
