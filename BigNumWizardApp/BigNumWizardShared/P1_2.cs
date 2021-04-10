using System;
using System.Collections.Generic;
using System.Text;

namespace BigNumWizardShared
{
    public class P1_2
    {

        public static Polynomial ADD_PP_P(int m1, List<BigFraction> c1, int m2, List<BigFraction> c2)
        {
            var firstPolynom = new Polynomial(new BigNum(m1.ToString()), c1);
            var secondPolynom = new Polynomial(new BigNum(m2.ToString()), c2);

            var resultOdds = new List<BigFraction>();

            int i = m1, j = m2;

            while (i >= 0 || j >= 0)
            {
                var firParam = i >= 0 ? firstPolynom.Odds[i] : new BigFraction(BigNum.Zero);
                var secParam = j >= 0 ? secondPolynom.Odds[j] : new BigFraction(BigNum.Zero);

                resultOdds.Insert(0, Q5_7.ADD_QQ_Q(firParam, secParam)); // вставляем в анчало сумму коэффициентов 

                i--; j--;
            }

            var max = new BigNum((resultOdds.Count - 1).ToString()); // старшая степень равна количеству коэффициентов минус 1

            var resultPolynom = new Polynomial(max, resultOdds);

            return resultPolynom;
        }

        public static Polynomial SUB_PP_P(int m1, List<BigFraction> c1, int m2, List<BigFraction> c2)
        {
            var firstPolynom = new Polynomial(new BigNum(m1.ToString()), c1);
            var secondPolynom = new Polynomial(new BigNum(m2.ToString()), c2);

            var resultOdds = new List<BigFraction>();

            int i = m1, j = m2;

            while (i >= 0 || j >= 0)
            {
                var firParam = i >= 0 ? firstPolynom.Odds[i] : new BigFraction(BigNum.Zero);
                var secParam = j >= 0 ? secondPolynom.Odds[j] : new BigFraction(BigNum.Zero);

                resultOdds.Insert(0, Q6.SUB_QQ_Q(firParam, secParam)); // вставляем в начало разность коэффициентов

                i--; j--;
            }

            var max = new BigNum((resultOdds.Count - 1).ToString()); // старшая степень равна количеству коэффициентов минус 1

            var resultPolynom = new Polynomial(max, resultOdds);

            return resultPolynom;
        }


    }
}
