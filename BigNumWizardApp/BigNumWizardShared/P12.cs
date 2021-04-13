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
                for (var i = BigNum.Zero; i < m; i = i + BigNum.One)                         // Все степени понижаются, нулевая исчезает, коэффициенты при остальных
                    result.Odds[i.ConvertToInt()] = result.Odds[i.ConvertToInt() + 1] * new BigFraction(i + BigNum.One);  // равны произведению коэффициента при следующей степени на её показатель
                result.Odds.RemoveAt(m.ConvertToInt());
                result.SeniorDegree = m - BigNum.One;                        
            }
            else
                result.Odds[0] = new BigFraction(BigNum.Zero);                                 // Производная многочлена нулевой степени - нуль
            return result;
        }
    }
}
