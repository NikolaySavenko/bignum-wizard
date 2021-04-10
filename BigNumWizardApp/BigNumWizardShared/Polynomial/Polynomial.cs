using BigNumWizardShared;
using System;
using System.Collections.Generic;
using System.Text;

namespace BigNumWizardShared
{
    public class Polynomial
    {
        public BigNum SeniorDegree { get; set; }
        public List<BigFraction> Odds { get; set; }
        public Polynomial(BigNum m, List<BigFraction> C)
        {
            SeniorDegree = m;
            Odds = C;
        }

        public override bool Equals(object obj) { return Equals(obj as Polynomial); }

        public bool Equals(Polynomial other) 
        { 
            for (int i = 0; i < other.Odds.Count; i++)
            {
                if (other.Odds[i] != Odds[i])
                {
                    return false;
                }
            }
            return other != null && other.SeniorDegree == SeniorDegree;
        }
    }
}
