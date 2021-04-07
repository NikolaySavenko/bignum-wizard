using System;
using System.Collections.Generic;
using System.Text;

namespace BigNumWizardShared
{
    public class Z10
    {
        public static BigNum MOD_ZZ_Z(BigNum fir, BigNum sec, out BigNum remainer)
        {
            BigNum tmp_fir;
            BigNum tmp_sec;

            if (z2_3.POZ_Z_D(fir) == 2 && z2_3.POZ_Z_D(sec) == 2)
            {
                tmp_fir = Z9.DIV_ZZ_Z(fir, sec, out remainer);
                tmp_sec = Z8.MUL_ZZ_Z(tmp_fir, sec);

                remainer = Z7.SUB_ZZ_Z(fir, tmp_sec);
                
                return remainer;
            }
            else if(z2_3.POZ_Z_D(fir) == 1 && z2_3.POZ_Z_D(sec) == 2)
            {
                tmp_fir = z2_3.MUL_ZM_Z(fir);

                tmp_fir = Z9.DIV_ZZ_Z(tmp_fir, sec, out remainer);
                tmp_sec = Z8.MUL_ZZ_Z(tmp_fir + BigNum.One, sec);

                remainer = Z7.SUB_ZZ_Z(tmp_sec, fir);
                return remainer;
            }
            else if(z2_3.POZ_Z_D(fir) == 2 && z2_3.POZ_Z_D(sec) == 1)
            {
                tmp_sec = z2_3.MUL_ZM_Z(sec);

                tmp_fir = Z9.DIV_ZZ_Z(fir, tmp_sec, out remainer);
                tmp_sec = Z8.MUL_ZZ_Z(tmp_fir + BigNum.One, sec);

                remainer = Z7.SUB_ZZ_Z(tmp_sec, fir);
                return remainer;
            }
            else if(z2_3.POZ_Z_D(fir) == 1 && z2_3.POZ_Z_D(sec) == 1)
            {
                tmp_fir = z2_3.MUL_ZM_Z(fir);
                tmp_sec = z2_3.MUL_ZM_Z(sec);

                remainer = Z9.DIV_ZZ_Z(tmp_sec, tmp_sec, out remainer);
                remainer = Z8.MUL_ZZ_Z(remainer + BigNum.One, tmp_sec);

                remainer = Z7.SUB_ZZ_Z(tmp_fir, remainer);
                return remainer;
            }
            else
                throw new Exception("Something went wrong");
        }
    }
}
