using System.Collections.Generic;

namespace BigNumWizardShared
{
    public class P13
    {
        public static Polynomial NMR_P_P(BigNum m, List<BigFraction> C)
        {
            var C_der = P12.DER_P_P(m, C);
            var devider = P11.GCF_PP_P(m, C, C_der.SeniorDegree, C_der.Odds);
            var result = P9.DIV_PP_P(m, C, devider.SeniorDegree, devider.Odds);
            return result;
        }
    }
}
