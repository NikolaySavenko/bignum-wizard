using System;
using System.Collections.Generic;
using System.Text;

namespace BigNumWizardShared
{
    public class Rational
    {
        public static BigFraction ADD_QQ_Q(BigFraction fir, BigFraction sec)    // Сумма дробей (Осипцов, 0305)
        {
            BigFraction result = new BigFraction();
                                                                                // Знаменатель - произведение знаменателей слагаемых
            result.denominator = MUL_ZZ_Z(fir.denominator, sec.denominator);    // Числитель - сумма произведений знаменателей каждой дроби на числитель другой
            result.nominator = SUM_ZZ_Z(MUL_ZZ_Z(fir.nominator, sec.denominator), MUL_ZZ_Z(fir.denominator, sec.nominator));//
            return result;
        }

        public static BigFraction MUL_QQ_Q(BigFraction fir, BigFraction sec)    // Произведение дробей (Осипцов, 0305)
        {
            BigFraction result = new BigFraction();

            result.nominator = MUL_ZZ_Z(fir.nominator, sec.nominator);          // Числитель - произведение числителей множителей
            result.denominator = MUL_ZZ_Z(fir.denominator, sec.nominator);      // Знаменатель - произведение знаменателей множителей
            return result;
        }
    }
}

// Возможны дальнейшие поправки по мере реализации дробей
// BigFraction - возможная реализация класса дробей, где nominator - числитель, denominator - знаменатель