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
                int n = m.ConvertToInt();
                for (int i = 0; i < n; i++)                         // Все степени понижаются, нулевая исчезает, коэффициенты при остальных
                    result.Odds[i] = result.Odds[i + 1] * new BigFraction(new BigNum(i.ToString()) + BigNum.One);  // равны произведению коэффициента при следующей степени на её показатель
                result.Odds.RemoveAt(n);
                result.SeniorDegree = m - BigNum.One;                        
            }
            else
                result.Odds[0] = new BigFraction(BigNum.Zero);                                 // Производная многочлена нулевой степени - нуль
            return result;
        }
    }
}
