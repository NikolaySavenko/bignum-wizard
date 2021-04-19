using System;
using System.Collections.Generic;
using System.Text;

namespace BigNumWizardShared
{
    public class P1_2 
    {

        public static Polynomial ADD_PP_P(BigNum m1, List<BigFraction> c1, BigNum m2, List<BigFraction> c2)
        {
            var firstPolynom = new Polynomial(m1, c1);
            var secondPolynom = new Polynomial(m2, c2);

            var resultOdds = new List<BigFraction>();

            int i = m1.ConvertToInt(), j = m2.ConvertToInt();

            while (i >= 0 || j >= 0)
            {
                var firParam = i >= 0 ? firstPolynom.Odds[i] : new BigFraction(BigNum.Zero);
                var secParam = j >= 0 ? secondPolynom.Odds[j] : new BigFraction(BigNum.Zero);

                resultOdds.Insert(0, Q5_7.ADD_QQ_Q(firParam, secParam)); // вставляем в начало сумму коэффициентов 

                i--;j--;
            }

            var max = new BigNum((resultOdds.Count - 1).ToString()); // старшая степень равна количеству коэффициентов минус 1

            var resultPolynom = new Polynomial(max, resultOdds);

            return resultPolynom;
        }

        public static Polynomial SUB_PP_P(BigNum m1, List<BigFraction> c1, BigNum m2, List<BigFraction> c2)
        {
            var firstPolynom = new Polynomial(m1, c1);
            var secondPolynom = new Polynomial(m2, c2);

            var resultOdds = new List<BigFraction>();

            int i = m1.ConvertToInt(), j = m2.ConvertToInt();

            while (i >= 0 || j >= 0)
            {
                var firParam = i >= 0 ? firstPolynom.Odds[i] : new BigFraction(BigNum.Zero);
                var secParam = j >= 0 ? secondPolynom.Odds[j] : new BigFraction(BigNum.Zero);

                resultOdds.Insert(0, Q6.SUB_QQ_Q(firParam, secParam)); // вставляем в начало разность коэффициентов

                i--;
                j--;
            }

            while(resultOdds[0].Nom == BigNum.Zero && resultOdds.Count>1)
            {
                resultOdds.RemoveAt(0);
            }

            var max = new BigNum((resultOdds.Count - 1).ToString()); // старшая степень равна количеству коэффициентов минус 1

            var resultPolynom = new Polynomial(max, resultOdds);

            return resultPolynom;
        }


    }
}
