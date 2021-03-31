namespace BigNumWizardShared
{
    public class N4_13
    {
        public static BigNum ADD_NN_N(BigNum fir, BigNum sec)  // N-4, сумма натуральных чисел, Осипцов Никита 0305
        {
            if (Natural1_5.COM_NN_D(fir, sec) == 1)
                return sec + fir;                   // Если первое число меньше, прибавить первое ко второму
            else
                return fir + sec;                   // Иначе прибавить второе к первому
        }
        public static BigNum GCF_NN_N(BigNum firInp, BigNum secInp)  // N-13, НОД натуральных чисел, Осипцов Никита 0305
        {
            var fir = new BigNum(firInp);
            var sec = new BigNum(secInp);

            while(N2_6.NZER_N_B(fir) == "yes" && N2_6.NZER_N_B(sec) == "yes")
                if (Natural1_5.COM_NN_D(fir, sec) == 2)
                    fir = fir % sec;
                else 
                    sec = sec % fir;
            if (Natural1_5.COM_NN_D(fir, sec) == 2)
                return fir;
            else
                return sec;
        }   // Результат содержит незначащие нули
    }
}
