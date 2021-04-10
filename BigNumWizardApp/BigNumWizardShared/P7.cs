using BigNumWizardShared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigNumWizardShared //Bratsun
{
    public class P7
    {
        public static BigFraction FAC_P_Q(int m, List<BigFraction> C) //Вынесение из многочлена НОК знаменателей коэффициентов и НОД числителей
        {
            var polynom = new Polynomial(new BigNum(m.ToString()), C);
            BigNum count = BigNum.One;
            BigNum[] mass = new BigNum[m - 1];
            BigNum[] array = new BigNum[m - 1];
            if (m != 0)
            {
                for (int i = 0; i < m - 1; i++)
                {
                    BigNum nom = polynom.Odds[i].Nom;
                    mass[i] = nom;
                }
                BigNum reduce(BigNum acc, BigNum[] arr)
                {
                    int i;
                    for (i = 0; i < m - 1; i++)
                    {
                        acc = gcd(acc, arr[i]);
                    }
                    return acc;
                }

                BigNum gcd(BigNum a, BigNum b)
                {
                    if (b > a) return gcd(b, a);
                    if (b == BigNum.Zero)
                        return a;
                    else
                        return gcd(b, a % b);
                }


                for (int i = 0; i < m - 1; i++)
                {
                    BigNum denom = polynom.Odds[i].Denom;
                    array[i] = denom;
                }
                BigNum GCD(BigNum a, BigNum b)
                {
                    while (a - b != BigNum.Zero)
                    {
                        if (a > b)
                            a -= b;
                        else
                            b -= a;
                    }
                    return a;
                }

                BigNum M = array[0];
                for (int i = 1; i < m-1; i++)
                {
                    M = (M * array[i]) / GCD(M, array[i]);
                }
                return new BigFraction(reduce(mass[0], mass), M); //НОД числителей /НОК знаменателей
            }
            else
            {
                return new BigFraction(polynom.Odds[0].Nom, polynom.Odds[0].Denom);
            }

        }
    }
}
