using System.Collections.Generic;

namespace BigNumWizardShared
{
   public class P12
    {
        public static Polynomial DER_P_P(int m, List<int> C) // P12, производная многочлена, Осипцов Никита 0305
        {
            var result = new Polynomial(m, C);

            if (m != 0) 
            {
                for (int i = 0; i < m; i++)                         // Все степени понижаются, нулевая исчезает, коэффициенты при остальных
                    result.Odds[i] = result.Odds[i + 1] * (i + 1);  // равны произведению коэффициента при следующей степени на её показатель
                result.Odds.RemoveAt(m);          
                result.SeniorDegree = m - 1;                        
            }
            else
                result.Odds[0] = 0;                                 // Производная многочлена нулевой степени - нуль
            return result;
        }
    }
}
