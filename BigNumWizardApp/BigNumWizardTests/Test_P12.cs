using BigNumWizardShared;
using System.Collections.Generic;
using Xunit;

namespace BigNumWizardTests
{
	public class Test_P12 //Solovieva
	{
		[Theory, MemberData(nameof(Data))]

		public static void Derivative(BigNum m, List<BigFraction> C, Polynomial res)
		{
			var actual = P12.DER_P_P(m, C);
			Assert.Equal(actual, res);
		}

		public static IEnumerable<object[]> Data => new[]
		{
			new object[]
					{
						new BigNum("6"),
						new List<BigFraction>() { new BigFraction(new BigNum("423424"), new BigNum("2324")), new BigFraction(new BigNum("-12344"), new BigNum("5345")), new BigFraction(new BigNum("-1313"), new BigNum("534")), new BigFraction(new BigNum("123"), new BigNum("2342")), new BigFraction(new BigNum("1235"), new BigNum("425")), new BigFraction(new BigNum("-123"), new BigNum("53")), new BigFraction(new BigNum("123"), new BigNum("5442")), },
						new Polynomial(new BigNum("5"), new List<BigFraction>() { new BigFraction(new BigNum("2540544"), new BigNum("2324")), new BigFraction(new BigNum("-61720"), new BigNum("5345")), new BigFraction(new BigNum("-5252"), new BigNum("534")), new BigFraction(new BigNum("369"), new BigNum("2342")), new BigFraction(new BigNum("2470"), new BigNum("425")), new BigFraction(new BigNum("-123"), new BigNum("53")), })
					},
			new object[]
					{
						new BigNum("0"),
						new List<BigFraction>() { new BigFraction(new BigNum("123"), new BigNum("12")), },
						new Polynomial(new BigNum("0"), new List<BigFraction>() { new BigFraction(BigNum.Zero) })
					},
			new object[]
					{
						new BigNum("8"),
						new List<BigFraction>() { new BigFraction(new BigNum("1244"), new BigNum("65332")),new BigFraction(new BigNum("1313"), new BigNum("1123")),new BigFraction(new BigNum("64564"), new BigNum("25645")),new BigFraction(new BigNum("12313"), new BigNum("6353")),new BigFraction(new BigNum("-131"), new BigNum("535")),new BigFraction(new BigNum("1313"), new BigNum("53634")),new BigFraction(new BigNum("-12314455"), new BigNum("2523")),new BigFraction(new BigNum("0"), new BigNum("24324")),new BigFraction(new BigNum("12312314255"), new BigNum("252")), },
						new Polynomial(new BigNum("7"),new List<BigFraction>(){new BigFraction(new BigNum("9952"), new BigNum("65332")),new BigFraction(new BigNum("9191"), new BigNum("1123")),new BigFraction(new BigNum("387384"), new BigNum("25645")),new BigFraction(new BigNum("61565"), new BigNum("6353")),new BigFraction(new BigNum("-524"), new BigNum("535")),new BigFraction(new BigNum("3939"), new BigNum("53634")),new BigFraction(new BigNum("-24628910"), new BigNum("2523")),new BigFraction(new BigNum("0"), new BigNum("24324")),})
					},
			new object[]
					{
						new BigNum("5"),
						new List<BigFraction>() { new BigFraction(new BigNum("12"), new BigNum("1")),new BigFraction(new BigNum("124"), new BigNum("1")),new BigFraction(new BigNum("-12"), new BigNum("1")),new BigFraction(new BigNum("66"), new BigNum("1")),new BigFraction(new BigNum("123"), new BigNum("1")),new BigFraction(new BigNum("48"), new BigNum("1")), },
						new Polynomial(new BigNum("4"),new List<BigFraction>(){new BigFraction(new BigNum("60"), new BigNum("1")),new BigFraction(new BigNum("496"), new BigNum("1")),new BigFraction(new BigNum("-36"), new BigNum("1")),new BigFraction(new BigNum("132"), new BigNum("1")),new BigFraction(new BigNum("123"), new BigNum("1")),})
					},
			new object[]
					{
						new BigNum("18"),
						new List<BigFraction>() { new BigFraction(new BigNum("12"), new BigNum("321")),new BigFraction(new BigNum("12"), new BigNum("43")),new BigFraction(new BigNum("12"), new BigNum("534")),new BigFraction(new BigNum("765"), new BigNum("23")),new BigFraction(new BigNum("756"), new BigNum("12")),new BigFraction(new BigNum("543"), new BigNum("12")),new BigFraction(new BigNum("756"), new BigNum("12")),new BigFraction(new BigNum("76579"), new BigNum("12")),new BigFraction(new BigNum("43"), new BigNum("12")),new BigFraction(new BigNum("756"), new BigNum("213")),new BigFraction(new BigNum("765"), new BigNum("234")),new BigFraction(new BigNum("756"), new BigNum("234")),new BigFraction(new BigNum("876"), new BigNum("23")),new BigFraction(new BigNum("12"), new BigNum("876")),new BigFraction(new BigNum("12"), new BigNum("867")),new BigFraction(new BigNum("987"), new BigNum("12")),new BigFraction(new BigNum("86"), new BigNum("345")),new BigFraction(new BigNum("867"), new BigNum("234")),new BigFraction(new BigNum("867"), new BigNum("234")), },
						new Polynomial(new BigNum("17"),new List<BigFraction>(){new BigFraction(new BigNum("216"), new BigNum("321")),new BigFraction(new BigNum("204"), new BigNum("43")),new BigFraction(new BigNum("192"), new BigNum("534")),new BigFraction(new BigNum("11475"), new BigNum("23")),new BigFraction(new BigNum("10584"), new BigNum("12")),new BigFraction(new BigNum("7059"), new BigNum("12")),new BigFraction(new BigNum("9072"), new BigNum("12")),new BigFraction(new BigNum("842369"), new BigNum("12")),new BigFraction(new BigNum("430"), new BigNum("12")),new BigFraction(new BigNum("6804"), new BigNum("213")),new BigFraction(new BigNum("6120"), new BigNum("234")),new BigFraction(new BigNum("5292"), new BigNum("234")),new BigFraction(new BigNum("5256"), new BigNum("23")),new BigFraction(new BigNum("60"), new BigNum("876")),new BigFraction(new BigNum("48"), new BigNum("867")),new BigFraction(new BigNum("2961"), new BigNum("12")),new BigFraction(new BigNum("172"), new BigNum("345")),new BigFraction(new BigNum("867"), new BigNum("234")),})
					},
			new object[]
					{
						new BigNum("19"),
						new List<BigFraction>() { new BigFraction(new BigNum("-53457567"), new BigNum("234453")),new BigFraction(new BigNum("-23425674"), new BigNum("1312314")),new BigFraction(new BigNum("0"), new BigNum("645645")),new BigFraction(new BigNum("1231244"), new BigNum("645645")),new BigFraction(new BigNum("12315754"), new BigNum("746745")),new BigFraction(new BigNum("2342356756"), new BigNum("856765")),new BigFraction(new BigNum("234267589663"), new BigNum("21343235674575")),new BigFraction(new BigNum("-75674635"), new BigNum("234257585")),new BigFraction(new BigNum("243556"), new BigNum("8767532")),new BigFraction(new BigNum("96896756"), new BigNum("2342342565675")),new BigFraction(new BigNum("6767896756"), new BigNum("32423536658")),new BigFraction(new BigNum("756754"), new BigNum("8678945")),new BigFraction(new BigNum("34246"), new BigNum("857553")),new BigFraction(new BigNum("345675"), new BigNum("867545")),new BigFraction(new BigNum("246458"), new BigNum("85675353")),new BigFraction(new BigNum("756585"), new BigNum("3453657")),new BigFraction(new BigNum("-4567585"), new BigNum("23525689")),new BigFraction(new BigNum("47464"), new BigNum("8575644")),new BigFraction(new BigNum("-42424556475"), new BigNum("867867967")),new BigFraction(new BigNum("56475858"), new BigNum("453453542")), },
						new Polynomial(new BigNum("18"),new List<BigFraction>(){new BigFraction(new BigNum("-1015693773"), new BigNum("234453")),new BigFraction(new BigNum("-421662132"), new BigNum("1312314")),new BigFraction(new BigNum("0"), new BigNum("645645")),new BigFraction(new BigNum("19699904"), new BigNum("645645")),new BigFraction(new BigNum("184736310"), new BigNum("746745")),new BigFraction(new BigNum("32792994584"), new BigNum("856765")),new BigFraction(new BigNum("3045478665619"), new BigNum("21343235674575")),new BigFraction(new BigNum("-908095620"), new BigNum("234257585")),new BigFraction(new BigNum("2679116"), new BigNum("8767532")),new BigFraction(new BigNum("968967560"), new BigNum("2342342565675")),new BigFraction(new BigNum("60911070804"), new BigNum("32423536658")),new BigFraction(new BigNum("6054032"), new BigNum("8678945")),new BigFraction(new BigNum("239722"), new BigNum("857553")),new BigFraction(new BigNum("2074050"), new BigNum("867545")),new BigFraction(new BigNum("1232290"), new BigNum("85675353")),new BigFraction(new BigNum("3026340"), new BigNum("3453657")),new BigFraction(new BigNum("-13702755"), new BigNum("23525689")),new BigFraction(new BigNum("94928"), new BigNum("8575644")),new BigFraction(new BigNum("-42424556475"), new BigNum("867867967")),})
					},
			new object[]
					{
						new BigNum("4"),
						new List<BigFraction>() { new BigFraction(new BigNum("2345"), new BigNum("764")),new BigFraction(new BigNum("2132"), new BigNum("564")),new BigFraction(new BigNum("23425"), new BigNum("75665")),new BigFraction(new BigNum("-23425"), new BigNum("6454")),new BigFraction(new BigNum("12312"), new BigNum("645")), },
						new Polynomial(new BigNum("3"),new List<BigFraction>(){new BigFraction(new BigNum("9380"), new BigNum("764")),new BigFraction(new BigNum("6396"), new BigNum("564")),new BigFraction(new BigNum("46850"), new BigNum("75665")),new BigFraction(new BigNum("-23425"), new BigNum("6454")),})
					},
			new object[]
					{
						new BigNum("6"),
						new List<BigFraction>() { new BigFraction(new BigNum("-2342342"), new BigNum("7566756")),new BigFraction(new BigNum("3453446"), new BigNum("34645785")),new BigFraction(new BigNum("-23424"), new BigNum("64645")),new BigFraction(new BigNum("353745"), new BigNum("23542354")),new BigFraction(new BigNum("457464"), new BigNum("56758")),new BigFraction(new BigNum("-234233"), new BigNum("756765")),new BigFraction(new BigNum("24231"), new BigNum("346")), },
						new Polynomial(new BigNum("5"),new List<BigFraction>(){new BigFraction(new BigNum("-14054052"), new BigNum("7566756")),new BigFraction(new BigNum("17267230"), new BigNum("34645785")),new BigFraction(new BigNum("-93696"), new BigNum("64645")),new BigFraction(new BigNum("1061235"), new BigNum("23542354")),new BigFraction(new BigNum("914928"), new BigNum("56758")),new BigFraction(new BigNum("-234233"), new BigNum("756765")),})
					},
			new object[]
					{
						new BigNum("8"),
						new List<BigFraction>() { new BigFraction(new BigNum("-1234"), new BigNum("64563")),new BigFraction(new BigNum("234564"), new BigNum("13123")),new BigFraction(new BigNum("123425"), new BigNum("45674")),new BigFraction(new BigNum("-6475"), new BigNum("24234")),new BigFraction(new BigNum("86786"), new BigNum("342112")),new BigFraction(new BigNum("7675756"), new BigNum("342423332")),new BigFraction(new BigNum("123145"), new BigNum("75675")),new BigFraction(new BigNum("789"), new BigNum("2342")),new BigFraction(new BigNum("-756765"), new BigNum("23425")), },
						new Polynomial(new BigNum("7"),new List<BigFraction>(){new BigFraction(new BigNum("-9872"), new BigNum("64563")),new BigFraction(new BigNum("1641948"), new BigNum("13123")),new BigFraction(new BigNum("740550"), new BigNum("45674")),new BigFraction(new BigNum("-32375"), new BigNum("24234")),new BigFraction(new BigNum("347144"), new BigNum("342112")),new BigFraction(new BigNum("23027268"), new BigNum("342423332")),new BigFraction(new BigNum("246290"), new BigNum("75675")),new BigFraction(new BigNum("789"), new BigNum("2342")),})
					},
			new object[]
					{
						new BigNum("1"),
						new List<BigFraction>() { new BigFraction(new BigNum("98873"), new BigNum("534535")),new BigFraction(new BigNum("-3245"), new BigNum("234")), },
						new Polynomial(new BigNum("0"),new List<BigFraction>(){new BigFraction(new BigNum("98873"), new BigNum("534535")),})
					}
		};
	};
}