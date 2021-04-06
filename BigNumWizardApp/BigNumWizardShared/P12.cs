﻿using System.Collections.Generic;

namespace BigNumWizardShared
{
   public class P12
    {
        public static Polynomial DER_P_P(int m, List<BigFraction> C) // P12, производная многочлена, Осипцов Никита 0305
        {
            var result = new Polynomial(new BigNum(m.ToString()), C);

            if (m != 0) 
            {
                for (int i = 0; i < m; i++)                         // Все степени понижаются, нулевая исчезает, коэффициенты при остальных
                    result.Odds[i] = result.Odds[i + 1] * new BigFraction(new BigNum((i + 1).ToString()));  // равны произведению коэффициента при следующей степени на её показатель
                result.Odds.RemoveAt(m);          
                result.SeniorDegree = new BigNum((m - 1).ToString());                        
            }
            else
                result.Odds[0] = new BigFraction(BigNum.Zero);                                 // Производная многочлена нулевой степени - нуль
            return result;
        }
    }
}
