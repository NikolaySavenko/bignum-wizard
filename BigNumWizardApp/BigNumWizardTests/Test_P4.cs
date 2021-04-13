using Xunit;
using BigNumWizardShared;
using System.Collections.Generic;

namespace BigNumWizardTests
{
    public class Test_P4 //Lukina
    {
        [Theory, MemberData(nameof(Data))]
        
        public static void PolynomialMult(int m, List<BigFraction> c, BigNum k, Polynomial expected)
        {
            Polynomial polynom = P4_5.MUL_Pxk_P(m, c, k);
            Assert.Equal(expected.Odds, polynom.Odds);
        }

        public static IEnumerable<object[]> Data
              {
                  get
                  {
                      return new[]
                      {
                          new object[] {
                              1,
                              new List<BigFraction>() { new BigFraction(new BigNum("2")), new BigFraction(new BigNum("2")) },
                              BigNum.One,
                              new Polynomial(new BigNum("2"), new List<BigFraction>() { new BigFraction(new BigNum("2")), new BigFraction(new BigNum("2")), new BigFraction(BigNum.Zero) })
                          },
                          
                          new object[] {
                              2,
                              new List<BigFraction>() { new BigFraction(new BigNum("123456")), new BigFraction(new BigNum("2345")), new BigFraction(new BigNum("2")) },
                              new BigNum("2"),
                              new Polynomial(new BigNum("4"), new List<BigFraction>() { new BigFraction(new BigNum("123456")), new BigFraction(new BigNum("2345")), new BigFraction(new BigNum("2")), new BigFraction(new BigNum("0")), new BigFraction(new BigNum("0")) })
                          },

                          new object[] {
                              3,
                              new List<BigFraction>() { new BigFraction(new BigNum("-123456587867676877867")), new BigFraction(new BigNum("2345")), new BigFraction(new BigNum("2")), new BigFraction(new BigNum("26767")) },
                              new BigNum("2"),
                              new Polynomial(new BigNum("5"), new List<BigFraction>() { new BigFraction(new BigNum("-123456587867676877867")), new BigFraction(new BigNum("2345")), new BigFraction(new BigNum("2")), new BigFraction(new BigNum("26767")), new BigFraction(new BigNum("0")), new BigFraction(new BigNum("0")) })
                          },


                          new object[] {
                              5,
                              new List<BigFraction>() { new BigFraction(new BigNum("12345658786567567567676877867")), new BigFraction(new BigNum("-2346576675")), new BigFraction(new BigNum("2")), new BigFraction(new BigNum("26767")), new BigFraction(new BigNum("26454767")), new BigFraction(BigNum.Zero) },
                              BigNum.One,
                              new Polynomial(new BigNum("6"), new List<BigFraction>() { new BigFraction(new BigNum("12345658786567567567676877867")), new BigFraction(new BigNum("-2346576675")), new BigFraction(new BigNum("2")), new BigFraction(new BigNum("26767")), new BigFraction(new BigNum("26454767")), new BigFraction(BigNum.Zero), new BigFraction(BigNum.Zero) })
                          },

                          new object[] {
                              5,
                              new List<BigFraction>() { new BigFraction(BigNum.Zero), new BigFraction(BigNum.Zero), new BigFraction(BigNum.Zero), new BigFraction(BigNum.Zero), new BigFraction(BigNum.Zero), new BigFraction(BigNum.Zero) },
                              BigNum.One,
                              new Polynomial(new BigNum("6"), new List<BigFraction>() { new BigFraction(BigNum.Zero), new BigFraction(BigNum.Zero), new BigFraction(BigNum.Zero), new BigFraction(BigNum.Zero), new BigFraction(BigNum.Zero), new BigFraction(BigNum.Zero), new BigFraction(BigNum.Zero) })
                          },

                          new object[] {
                              2,
                              new List<BigFraction>() { new BigFraction(new BigNum("-123456587867676877867777777")), new BigFraction(new BigNum("-23333345")), new BigFraction(new BigNum("-2"))},
                              new BigNum("3"),
                              new Polynomial(new BigNum("5"), new List<BigFraction>() { new BigFraction(new BigNum("-123456587867676877867777777")), new BigFraction(new BigNum("-23333345")), new BigFraction(new BigNum("-2")), new BigFraction(BigNum.Zero), new BigFraction(BigNum.Zero), new BigFraction(BigNum.Zero) })
                          },

                          new object[] {
                              1,
                              new List<BigFraction>() { new BigFraction(new BigNum("22222222")), new BigFraction(new BigNum("-223456789")) },
                              BigNum.Zero,
                              new Polynomial(new BigNum("2"), new List<BigFraction>() { new BigFraction(new BigNum("22222222")), new BigFraction(new BigNum("-223456789")) })
                          },

                      };
                  }
              }
    }
}