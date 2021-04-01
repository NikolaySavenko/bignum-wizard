using Xunit;
using System;
using BigNumWizardShared;
using System.Collections.Generic;
using System.Collections;
using Xunit.Extensions;

namespace BigNumWizardTests
{
    public class Test_P6 //Petrakova
    {
        [Theory, MemberData(nameof(Data))]

        public static void SeniorDegree(int m, List<int> c, int res)
        {
            var actual = P_6.DEG_P_N(m, c);
            Assert.Equal(actual, res);
        }  

        public static IEnumerable<object[]> Data
        {
            get
            {
                return new[]
                {
                    new object[] { 1, new List<int>() { 1, 2 }, 1 },
                    new object[] { 6, new List<int>() { 534, 1775, 98888, 976, 180, 432, 0 }, 6},
                    new object[] { 5, new List<int>() { 4543, 21, 1111, 5448, 866, 2342 }, 5},
                    new object[] { 0, new List<int>() { 126545 }, 0},
                    new object[] { 8, new List<int>() { 0, 12, 832, 0, 0, 12274246, 0, 900, 126 }, 8},
                    new object[] { 2, new List<int>() { 0, 0, 99132 }, 2}
                };
            }
        }

    }
}
