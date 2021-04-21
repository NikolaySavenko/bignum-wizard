using System;
using System.Collections.Generic;
using System.Text;

namespace BigNumWizardShared
{                                         
    public class P8
    {
        public static Polynomial MUL_PP_P(BigNum m1, List<BigFraction> c1, BigNum m2, List<BigFraction> c2) //Умножение многочленов Кабанов 0305
        {                        
            var result = new List<BigFraction>() {new BigFraction(BigNum.Zero)};  

            var output = new Polynomial(BigNum.Zero, result);           //пустой многочлен, в котором накапливается результат
            
            int s;
            Polynomial Polynom;
            BigNum fir_param;
            List<BigFraction> sec_param;
            BigNum check;

            if (m1 > m2|| m1 == m2)                 //для уменьшения количества выполнения цикла
            {                                       //(больший полином по количеству элементов умножаеnся на меньший)
                Polynom = new Polynomial(m2, c2);
                s = m2.ConvertToInt();
                if (m2 == BigNum.Zero)
                    s = m2.ConvertToInt();

                fir_param = m1;
                sec_param = c1.GetRange(0, c1.Count); 

                check = m2;
            }
            else
            {
                Polynom = new Polynomial(m1, c1);
                s = m1.ConvertToInt();
                if (m1 == BigNum.Zero)
                    s = m1.ConvertToInt();

                fir_param = m2;
                sec_param = c2.GetRange(0, c2.Count);

                check = m1;
            }

            int j = s;
            var f = BigNum.Zero;

            for (int i = 0; i <= s; i++)
            {
                if (Polynom.Odds[i] == new BigFraction(BigNum.Zero))
                    continue;
                else
                {
                    var multy = new Polynomial(BigNum.Zero, result);                             //вспомогательный многочлен(для умножения на коэффициенты и x^k)
                    multy = P3.MUL_PQ_P(fir_param, sec_param, Polynom.Odds[i]);                  //умножаем многочлен на коэффициент второго

                    if(m1 > m2 || m1 == m2)
                        sec_param = c1.GetRange(0, c1.Count);               
                    else
                        sec_param = c2.GetRange(0, c2.Count);

                    multy = P4_5.MUL_Pxk_P(fir_param, multy.Odds, new BigNum(j.ToString()));  //умножаем многочлен на x^j текущего элемента второго многочлена
                    j--;

                    var k = new BigNum(multy.Odds.Count.ToString());
                    k = Z7.SUB_ZZ_Z(k, BigNum.One);

                    output = P1_2.ADD_PP_P(f, output.Odds, k , multy.Odds);                      //складываем многочлены

                    f = new BigNum(output.Odds.Count.ToString());
                    f = Z7.SUB_ZZ_Z(f, BigNum.One);
                }
                
            }

            while (output.Odds[0].Nom == BigNum.Zero && output.Odds.Count > 1)
            {
                output.Odds.RemoveAt(0);
            }

            var max = new BigNum((output.Odds.Count - 1).ToString());

            output = new Polynomial(max, output.Odds);

            return output;
        }

    }
}
