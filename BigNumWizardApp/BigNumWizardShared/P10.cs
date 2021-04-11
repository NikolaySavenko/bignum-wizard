using System.Collections.Generic;

namespace BigNumWizardShared
{
    public class P10  //P-10 Остаток от деления многочлена на многочлен при делении с остатком Петракова Марина 0305
    {
        public static Polynomial MOD_PP_P(int m1, List<BigFraction> C1, int m2, List<BigFraction> C2)
        {
            int deg = m1 - m2;
            int modDeg = m2 - 1;

            var resultSeniorDegree = new BigNum(modDeg.ToString());
            var odds = new List<BigFraction>();
            var resultOdds = C1;

            for (int i = 0; i < deg + 1; i++)
            {
                odds.Add(Q8.DIV_QQ_Q(resultOdds[0], C2[0]));

                for (int j = 0; j < m2; j++)
                {
                    resultOdds[j] = Q6.SUB_QQ_Q(resultOdds[j], Q5_7.MUL_QQ_Q(C2[j], odds[i]));
                }
                resultOdds.RemoveAt(0);
            }

            var resultPolynom = new Polynomial(resultSeniorDegree, resultOdds);

            return resultPolynom;
        }
    }
}
