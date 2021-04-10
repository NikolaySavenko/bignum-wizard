using System;
using System.Collections.Generic;
using System.Text;

namespace BigNumWizardShared
{
    public class Z10
    {
        public static BigNum MOD_ZZ_Z(BigNum fir, BigNum sec, out BigNum remainer)  //Остаток от деления целого на целое(делитель отличен от нуля) Кабанов 0305
        {
            remainer = BigNum.Zero;
            if (z2_3.POZ_Z_D(fir) == 2 && z2_3.POZ_Z_D(sec) == 2)
            {
                remainer = Z9.DIV_ZZ_Z(fir, sec, out _);

                if (Z8.MUL_ZZ_Z(remainer, sec) == fir)
                    return BigNum.Zero;
                else if (Z9.DIV_ZZ_Z(fir, sec, out _) == BigNum.Zero)
                {
                    return fir;
                }
                else
                {
                    remainer = Z8.MUL_ZZ_Z(sec, remainer);
                    remainer = Z7.SUB_ZZ_Z(fir, remainer);
                    return remainer;
                }
            }
            else if (z2_3.POZ_Z_D(fir) == 1 && z2_3.POZ_Z_D(sec) == 2)
            {
                remainer = Z9.DIV_ZZ_Z(fir, sec, out _);

                if (Z8.MUL_ZZ_Z(remainer, sec) == fir)
                    return BigNum.Zero;
                else if (Z9.DIV_ZZ_Z(fir, sec, out _) == BigNum.Zero)
                {
                    //remainer = z2_3.MUL_ZM_Z(fir);
                    remainer = Z7.SUB_ZZ_Z(fir, fir + fir);
                    return remainer;
                }
                else
                {

                    remainer = Z8.MUL_ZZ_Z(sec, remainer + BigNum.MinusOne);
                    remainer = Z7.SUB_ZZ_Z(fir, remainer);

                    return remainer;
                }
            }
            else if (z2_3.POZ_Z_D(fir) == 2 && z2_3.POZ_Z_D(sec) == 1)
            {

                remainer = Z9.DIV_ZZ_Z(fir, sec, out _);

                if (Z8.MUL_ZZ_Z(remainer, sec) == fir)
                    return BigNum.Zero;
                else if (Z9.DIV_ZZ_Z(fir, sec, out _) == BigNum.Zero)
                {
                    return fir;
                }
                else
                {
                    remainer = Z8.MUL_ZZ_Z(sec, remainer);

                    remainer = Z7.SUB_ZZ_Z(fir, remainer);
                    return remainer;
                }

            }
            else if (z2_3.POZ_Z_D(fir) == 1 && z2_3.POZ_Z_D(sec) == 1)
            {
                remainer = Z9.DIV_ZZ_Z(fir, sec, out _);

                if (Z8.MUL_ZZ_Z(remainer, sec) == fir)
                    return BigNum.Zero;
                else if (Z9.DIV_ZZ_Z(fir, sec, out _) == BigNum.Zero)
                {
                    //remainer = z2_3.MUL_ZM_Z(fir);
                    remainer = Z7.SUB_ZZ_Z(fir, fir + fir);
                    return remainer;
                }
                else
                {

                    remainer = Z8.MUL_ZZ_Z(sec, remainer + BigNum.One);
                    remainer = Z7.SUB_ZZ_Z(fir, remainer);

                    return remainer;
                }
            }
            else if (z2_3.POZ_Z_D(fir) == 0)
                return BigNum.Zero;
            else
                throw new Exception("Something went wrong");
        }
    }
}
