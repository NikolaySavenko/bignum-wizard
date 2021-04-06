using System;
using System.Collections.Generic;
using System.Text;

namespace BigNumWizardShared
{
    public class Z6    
    {
        public static BigNum ADD_ZZ_Z(BigNum int_fir, BigNum int_sec)  //Сложение целых чисел. Кабанов 0305
        {
            BigNum natural_fir;
            BigNum natural_sec;
            BigNum result;

            if ((z2_3.POZ_Z_D(int_fir) == 2 || z2_3.POZ_Z_D(int_fir) == 0) && (z2_3.POZ_Z_D(int_sec) == 2 || z2_3.POZ_Z_D(int_sec) == 0))       //Если оба целых числа положительные или равны нулю
                return N4_13.ADD_NN_N(int_fir, int_sec);                                                                                        //Возвращаем сумму натуральных чисел
            else
                if ((z2_3.POZ_Z_D(int_fir) == 1 || z2_3.POZ_Z_D(int_fir) == 0) && (z2_3.POZ_Z_D(int_sec) == 1 || z2_3.POZ_Z_D(int_sec) == 0))   //Если оба целых числа отрицательные или равны нулю
            {
                natural_fir = Absolute.ABS_Z_N(int_fir);    //Находим модуль обоих чисел, складываем как натуральные                                                                     
                natural_sec = Absolute.ABS_Z_N(int_sec);

                result = N4_13.ADD_NN_N(natural_fir, natural_sec);

                return z2_3.MUL_ZM_Z(result);               //Возвращаем результат, умноженный на -1
            }
            else
                if (z2_3.POZ_Z_D(int_fir) == 1 && z2_3.POZ_Z_D(int_sec) == 2)       //Если первое - отрицательное, а второе - положительное
            {
                natural_fir = Absolute.ABS_Z_N(int_fir);                       //Получаем модуль первого
                natural_sec = int_sec;

                if (Natural1_5.COM_NN_D(natural_fir, natural_sec) == 2)        //Если первое по модулю больше второго
                {                                                              //Вычитаем из первого второе и возвращаем результат, умноженный на -1
                    result = Natural1_5.SUB_NN_N(natural_fir, natural_sec);

                    return z2_3.MUL_ZM_Z(result);
                }
                else
                    if (Natural1_5.COM_NN_D(natural_fir, natural_sec) == 1)    //Если второе по модолю больше первого
                {                                                          //Вычитаем из второго первое и возвращаем результат
                    result = Natural1_5.SUB_NN_N(natural_sec, natural_fir);

                    return result;
                }
                else
                    return Natural1_5.SUB_NN_N(natural_fir, natural_sec);
            }
            else                                                                 //Если первое - положительное, а второе - отрицательное
                //if (z2_3.POZ_Z_D(int_fir) == 2 && z2_3.POZ_Z_D(int_sec) == 1)
            {
                natural_fir = int_fir;
                natural_sec = Absolute.ABS_Z_N(int_sec);                         //Получаем модуль второго

                if (Natural1_5.COM_NN_D(natural_fir, natural_sec) == 2)          //Если первое по модулю больше второго
                {                                                                //Вычитаем из первого второе и возвращаем результат
                    result = Natural1_5.SUB_NN_N(natural_fir, natural_sec);

                    return result;
                }
                else
                    if (Natural1_5.COM_NN_D(natural_fir, natural_sec) == 1)      //Если второе по модолю больше первого
                {                                                            //Вычитаем из второго первое и возвращаем результат, умноженный на -1
                    result = Natural1_5.SUB_NN_N(natural_sec, natural_fir);

                    return z2_3.MUL_ZM_Z(result);
                }
                else
                    return Natural1_5.SUB_NN_N(natural_fir, natural_sec);

            }

        }
    }
}
