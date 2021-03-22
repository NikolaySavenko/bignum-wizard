namespace BigNumWizardShared
{
    class Natural
    {
        static BigNum ADD_NN_N(BigNum fir, BigNum sec)  // Сумма натуральных чисел (Осипцов, 0305)
        {
            if (COM_NN_D(fir, sec) == 1)
                return sec + fir;                   // Если первое число меньше, прибавить первое ко второму
            else
                return fir + sec;                   // Иначе прибавить второе к первому
        }

        static BigNum GCF_NN_N(BigNum fir, BigNum sec)  // НОД натуральных чисел (Осипцов, 0305)
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
