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
            while (r2.SeniorDegree != BigNum.Zero || r2.Odds[0].Nom != BigNum.Zero)
            {
                tmp = P10.MOD_PP_P(r1.SeniorDegree, r1.Odds, r2.SeniorDegree, r2.Odds);
                r1 = r2;
                r2 = tmp;
            }
            return r1;
        }
    }
}
