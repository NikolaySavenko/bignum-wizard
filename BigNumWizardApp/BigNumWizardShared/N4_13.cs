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
    }
}
