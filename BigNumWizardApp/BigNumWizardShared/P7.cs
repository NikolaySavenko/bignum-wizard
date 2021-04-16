using System.Collections.Generic;

namespace BigNumWizardShared //Bratsun
{
    public class P7
    {
        public static BigFraction FAC_P_Q(BigNum m, List<BigFraction> C) //Вынесение из многочлена НОК знаменателей коэффициентов и НОД числителей
        {
            var polynom = new Polynomial(m, C);
            int deg = m.ConvertToInt();
            BigNum[] mass = new BigNum[deg + 1];
            BigNum[] array = new BigNum[deg + 1];
            if (deg != 0)
            {
                for (int i = 0; i < deg + 1; i++)
                {
                    BigNum nom = polynom.Odds[i].Nom;
                    mass[i] = nom;
                }
                BigNum acc = mass[0];
                for (int i = 1; i < deg + 1; i++)
                {
                    acc = N4_13.GCF_NN_N(acc, mass[i]);
                }

                for (int i = 0; i < deg + 1; i++)
                {
                    BigNum denom = polynom.Odds[i].Denom;
                    array[i] = denom;
                }

                BigNum M = array[0];
                for (int i = 1; i < deg + 1; i++)
                {
                    M = N8_14.LCM_NN_N(M, array[i]);
                }
                return new BigFraction(acc, M); //НОД числителей /НОК знаменателей
            }
            else
            {
                return new BigFraction(polynom.Odds[0].Nom, polynom.Odds[0].Denom);
            }

        }
    }
}
