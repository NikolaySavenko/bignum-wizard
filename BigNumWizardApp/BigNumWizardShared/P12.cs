using System.Collections.Generic;

namespace BigNumWizardShared
{
   public class P12
    {
        public static Polynomial DER_P_P(BigNum m, List<BigFraction> C) // P12, производная многочлена, Осипцов Никита 0305
        {
            var result = new Polynomial(m, C);

            if (m != BigNum.Zero) 
            {
                for (int i = 0; i < m.ConvertToInt() ; i++)                         
                    result.Odds[i] = result.Odds[i] * new BigFraction(m - new BigNum(i.ToString()));  
                result.Odds.RemoveAt(m.ConvertToInt());
                result.SeniorDegree = m - BigNum.One;                        
            }
            else
                result.Odds[0] = new BigFraction(BigNum.Zero);                                 // Производная многочлена нулевой степени - нуль
            return result;
        }
    }
}
