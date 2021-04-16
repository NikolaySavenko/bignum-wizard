using BigNumWizardShared;
using System;
using System.Collections.Generic;
using System.Linq;
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
            var degreeCompare = other.SeniorDegree == SeniorDegree;
            var oddsCompare = Odds.SequenceEqual(other.Odds);
            var checkNull = other != null;
            return degreeCompare && oddsCompare && checkNull;
        }
    }
}
