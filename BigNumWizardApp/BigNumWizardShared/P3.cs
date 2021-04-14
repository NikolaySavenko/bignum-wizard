using System;
using System.Collections.Generic;
using System.Text;

namespace BigNumWizardShared
{
    public class P3
    {

        public static Polynomial MUL_PQ_P(BigNum m, List<BigFraction> C, BigFraction num)
        {
            var polynom = new Polynomial(m, C);
            for (var i = BigNum.Zero; i <= m; i = i + BigNum.One)
            {
                polynom.Odds[i.ConvertToInt()] = Q5_7.MUL_QQ_Q(polynom.Odds[i.ConvertToInt()], num);
            }

            return polynom;
        }


    }
}
