namespace BigNumWizardShared
{
    public class N4_13
    {
        public static BigNum ADD_NN_N(BigNum fir, BigNum sec)  // N-4, сумма натуральных чисел, Осипцов Никита 0305)
        {
            if (COM_NN_D(fir, sec) == 1)
                return sec + fir;                   // Если первое число меньше, прибавить первое ко второму
            else
                return fir + sec;                   // Иначе прибавить второе к первому
        }

        public static BigNum GCF_NN_N(BigNum fir, BigNum sec)  // N-13, НОД натуральных чисел, Осипцов Никита 0305)
        {
            while (NZER_N_B(fir) != 1 && NZER_N_B(sec) != 1)     // Алгоритм Евклида
                if (COM_NN_D(fir, sec) == 2)
                    fir = MOD_NN_N(fir, sec);
                else
                    sec = MOD_NN_D(sec, fir);
            if (NZER_N_B(fir) == 1)                             // Возврат ненулевого остатка
                return fir;
            else
                return sec;
        }
    }
}
