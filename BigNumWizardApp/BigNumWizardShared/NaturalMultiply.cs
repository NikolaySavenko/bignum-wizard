using System;
using System.Collections.Generic;
using System.Text;

namespace BigNumWizardShared
{
    class NaturalMultiply
    {
        public static List<byte> ADD_1N_N(List<byte> a)
        {

            int k = a.Count - 1;
            while (k != -1)
            {
                if (a[k] < 9)
                {
                    a[k]++;
                    k = -1;
                }
                else
                {
                    a[k] = 0;
                    k--;
                }
            }
            if (a[0] == 0)
            {
                a.Insert(0, 1);
            }
            return a;
        }

        public static List<byte> MUL_Nk_N(List<byte> a, int k)
        {
            for (int i = 0; i < k; i++)
            {
                a.Add(0);
            }
            return a;
        }
    }
}
