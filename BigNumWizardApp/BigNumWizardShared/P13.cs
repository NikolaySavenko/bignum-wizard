using System.Collections.Generic;

namespace BigNumWizardShared
{
    public class P13
    {
        public static Polynomial NMR_P_P(BigNum m, List<BigFraction> C)
        {
            var C_der = P12.DER_P_P(m, C);
            var divider = P11.GCF_PP_P(m, C, C_der.SeniorDegree, C_der.Odds);
            var result = P9.DIV_PP_P(m, C, divider.SeniorDegree, divider.Odds);

            var OddsGcf = P7.FAC_P_Q(result.SeniorDegree, result.Odds).Nom;
            var Inversed = new BigFraction(BigNum.One, OddsGcf);
            result = P3.MUL_PQ_P(result.SeniorDegree, result.Odds, Inversed);
            for (int i = 0; i < result.SeniorDegree.ConvertToInt() + 1; i++)
            {
                result.Odds[i] = Q1.RED_Q_Q(result.Odds[i]);
            }
            return result;
        }
    }
}
