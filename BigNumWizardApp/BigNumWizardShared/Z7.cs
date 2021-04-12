using System;
using System.Collections.Generic;
using System.Text;

namespace BigNumWizardShared
{
    public class Z7
    {
         public static BigNum SUB_ZZ_Z(BigNum A, BigNum B)  //// Z-7 Вычитание целых чисел. Иванов Артём 0305
        {
            BigNum abs1;
            BigNum abs2;
            BigNum res;
            if ((z2_3.POZ_Z_D(A) == 2 && z2_3.POZ_Z_D(B) == 1) || (z2_3.POZ_Z_D(A) == 1 && z2_3.POZ_Z_D(B) == 2))   //Если числа с разными знаками
            {
                if (z2_3.POZ_Z_D(B) == 1)
                {
                    abs2 = Absolute.ABS_Z_N(B);              //Модуль второго складываем с первым
                    res = A + abs2;
                    return res;
                }
                else
                {
                    abs1 = Absolute.ABS_Z_N(A);              //Модуль первого складываем со вторым
                    res = abs1 + B;
                    return z2_3.MUL_ZM_Z(res);               //Возвращаем результат, умноженный на -1
                }
            }
            else if ((z2_3.POZ_Z_D(A) == 1 && z2_3.POZ_Z_D(B) == 1))       //Если оба отрицательные
            {
                abs1 = Absolute.ABS_Z_N(A);    //Находим модуль обоих чисел                                                                    
                abs2 = Absolute.ABS_Z_N(B);
                if (Natural1_5.COM_NN_D(abs1, abs2) == 1)       //Если второе больше
                {
                    res = abs2 - abs1;
                    return res;
                }
                else if (Natural1_5.COM_NN_D(abs2, abs1) == 1)     //Если первое больше
                {
                    res = abs1 - abs2;
                    return z2_3.MUL_ZM_Z(res);       //Возвращаем результат, умноженный на -1

                }
                else
                    return new BigNum ("0");
            }
            else if ((z2_3.POZ_Z_D(A) == 2 && z2_3.POZ_Z_D(B) == 2))      //Если оба положительные
            {
                abs1 = Absolute.ABS_Z_N(A);    //Находим модуль обоих чисел                                                                    
                abs2 = Absolute.ABS_Z_N(B);
                if (Natural1_5.COM_NN_D(abs1, abs2) == 1)     //Если второе больше
                {
                    res = abs2 - abs1;
                    return z2_3.MUL_ZM_Z(res);
                }
                else if (Natural1_5.COM_NN_D(abs2, abs1) == 1)     //Если первое больше
                {
                    res = abs1 - abs2;
                    return res;
                }
                else
                    return BigNum.Zero;
            }
            else if ((z2_3.POZ_Z_D(A) == 0 && z2_3.POZ_Z_D(B) == 0))      // Если оба нули
                return A;
            else if ((z2_3.POZ_Z_D(A) == 2 && z2_3.POZ_Z_D(B) == 0) || (z2_3.POZ_Z_D(A) == 0 && z2_3.POZ_Z_D(B) == 2))      //Если одно положительное, другое - ноль
            {
                if (z2_3.POZ_Z_D(A) == 2)
                    return A;
                else
                    return z2_3.MUL_ZM_Z(B);
            }
            else       //Если одно отрицательное, другое - ноль
            {
                if (z2_3.POZ_Z_D(A) == 1)
                    return A;
                else
                {
                    abs2 = Absolute.ABS_Z_N(B);
                    return abs2;
                }
            }
        }
    }
}
