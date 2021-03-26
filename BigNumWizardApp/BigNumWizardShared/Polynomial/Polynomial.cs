using BigNumWizardShared;
using System;
using System.Collections.Generic;
using System.Text;

namespace BigNumWizardShared
{
    public class Polynomial
    {
        public int SeniorDegree { get; set; }
        public List<int> Odds { get; set; }
        public Polynomial(int m, List<int> C)
        {
            SeniorDegree = m;
            Odds = C;
        }
    }
}
