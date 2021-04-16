using System;
using System.Collections.Generic;
using System.Text;

namespace BigNumWizardShared
{
    public class P10 //P-10 Остаток от деления многочлена на многочлен при делении с остатком Петракова Марина 0305
    {
        public static Polynomial MOD_PP_P(BigNum m1, List<BigFraction> C1, BigNum m2, List<BigFraction> C2)
        {
            var div = P9.DIV_PP_P(m1, C1, m2, C2);
            var deg = div.SeniorDegree;
            var odds = div.Odds;
            var mul = P8.MUL_PP_P(m2, C2, deg, odds);
            var result = P1_2.SUB_PP_P(m1, C1, mul.SeniorDegree, mul.Odds);
            return result;
        }
    }
}
