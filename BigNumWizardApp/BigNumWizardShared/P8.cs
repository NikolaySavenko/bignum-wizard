using System;
using System.Collections.Generic;
using System.Text;

namespace BigNumWizardShared.Polynomial   //(x^2+x+1)*(2x+3)
{                                         //(x^2+x+1)*2x
                                          //+
                                          //(x^2+x+1)*3
    public class P8
    {
        public static Polynomial MUL_PP_P(int m1, List<BigFraction> c1, int m2, List<BigFraction> c2) //Умножение многочленов Кабанов 0305
        {
            var secondPolynom = new Polynomial(new BigNum(m2.ToString()), c2);
            
            var z = m1 * m2 - 1;
            var g = new BigNum(z.ToString());

            var result = new List<BigFraction>();
            var resultat = new Polynomial(g, result);
            
            var tmp_result = new List<BigFraction>();
            
            var finish = new List<BigFraction>();

            for (int i = m2; i >=0; i--)
            {
                resultat = P3.MUL_PQ_P(m1, c1, secondPolynom[i]);
                tmp_result = trans_polynom(resultat, z);

                var k = degree(m2, c2, i);

                resultat = P4_5.MUL_Pxk_P(z, tmp_result, k);
                tmp_result = trans_polynom(resultat, z);

                finish = P1_2.ADD_PP_P(z, finish, z, tmp_result); 
                
            }

            return finish;
        }

        static BigNum degree(int m, List<BigFraction> c, int k)
        {
            var Polynom = new Polynomial(new BigNum(m.ToString()), c);

            if (Polynom.Odds[k] == new BigFraction(BigNum.Zero))
                return BigNum.Zero;
            else
                return new BigNum(k.ToString());

        }

        static List<BigFraction> trans_polynom(Polynomial polynom, int g)
        {
            var result = new List<BigFraction>();

            while (g >= 0)
            {
                result.Add(polynom.Odds[g]);
                g--;
            }

            return result;
        }
    }
}
