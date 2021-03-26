using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
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
