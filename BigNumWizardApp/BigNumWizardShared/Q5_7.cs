namespace BigNumWizardShared
{
    public class Q5_7
    {
        public static BigFraction ADD_QQ_Q(BigFraction fir, BigFraction sec)    // Q-5, сложение дробей, Осипцов Никита 0305
        {
            var result = fir + sec; // Получить несокращённую дробь-сумму

            result = Q1.RED_Q_Q(result);
            return result;
        }
       
        public static BigFraction MUL_QQ_Q(BigFraction fir, BigFraction sec) { return fir * sec; } // Q-7, умножение дробей, Осипцов Никита 0305
    }
}
