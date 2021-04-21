using System;
using System.Collections.Generic;
using System.Text;

namespace BigNumWizardShared
{
    public class P11  //P-11 НОД многочленов Иванов Артём 0305
    {
        public static Polynomial GCF_PP_P(BigNum m1, List<BigFraction> C1, BigNum m2, List<BigFraction> C2)
        {
            var r1 = new Polynomial(m1, C1);
            var r2 = new Polynomial(m2, C2);
            var tmp = new Polynomial(m2, C2);

            if (m1 < m2) // Многочлен с большей степенью стоит первым
            {
                tmp = r1;
                r1 = r2;
                r2 = tmp;
            }
            while (r2.SeniorDegree != BigNum.Zero || r2.Odds[0].Nom != BigNum.Zero)   //Находим нод
            {
                tmp = P10.MOD_PP_P(r1.SeniorDegree, r1.Odds, r2.SeniorDegree, r2.Odds);
                r1 = r2;
                r2 = tmp;
            }
            var OddsGcf = P7.FAC_P_Q(r1.SeniorDegree, r1.Odds).Nom; //Сокращаем нод
            var Inversed = new BigFraction(BigNum.One, OddsGcf);
            r1 = P3.MUL_PQ_P(r1.SeniorDegree, r1.Odds, Inversed);
            for (int i = 0; i < r1.SeniorDegree.ConvertToInt() + 1; i++)
            {
                r1.Odds[i] = Q1.RED_Q_Q(r1.Odds[i]);
            }
            if (r1.Odds[0].Positive == false)
            {
                r1 = P3.MUL_PQ_P(r1.SeniorDegree, r1.Odds, new BigFraction(BigNum.MinusOne)); //Умножаем на минус 1, если необходимо (для красивого вывода)
            }
            return r1;
        }
    }
}
