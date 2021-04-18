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
						BigNum.One,
						new List<BigFraction>() { new BigFraction(BigNum.One), new BigFraction(new BigNum("2")) },
						new Polynomial(BigNum.Zero, new List<BigFraction>(){new BigFraction(new BigNum("2"))})
					},

					new object[]
					{
						new BigNum("2"),
						new List<BigFraction>() { new BigFraction(BigNum.One), new BigFraction(BigNum.Zero), new BigFraction(new BigNum("2344")) },
						new Polynomial(BigNum.One,new List<BigFraction>(){new BigFraction(BigNum.Zero),new BigFraction(new BigNum("4688"))})
					},

					new object[]
					{
						new BigNum("3"),
						new List<BigFraction>() { new BigFraction(new BigNum("34798547874")), new BigFraction(new BigNum("4")), new BigFraction(new BigNum("7654")), new BigFraction(new BigNum("2344")) },
						new Polynomial(new BigNum("2"),new List<BigFraction>(){new BigFraction(new BigNum("4")), new BigFraction(new BigNum("15308")), new BigFraction(new BigNum("7032"))})
					},

					new object[]
					{
						new BigNum("5"),
						new List<BigFraction>() { new BigFraction(new BigNum("1324134145255"), new BigNum("123134")), new BigFraction(new BigNum("1234524545"), new BigNum("1234125624")), new BigFraction(new BigNum("5634767634655"), new BigNum("143123414")), new BigFraction(new BigNum("3453534353562"), new BigNum("245246")),  new BigFraction(new BigNum("23"), new BigNum("645")),  new BigFraction(new BigNum("1234"), new BigNum("64567")) },
						new Polynomial(new BigNum("4"),new List<BigFraction>(){new BigFraction(new BigNum("1234524545"), new BigNum("1234125624")), new BigFraction(new BigNum("11269535269310"), new BigNum("143123414")), new BigFraction(new BigNum("10360603060686"), new BigNum("245246")), new BigFraction(new BigNum("92"), new BigNum("645")),  new BigFraction(new BigNum("6170"), new BigNum("64567"))})
					},

					new object[]
                    {
						BigNum.Zero,
						new List<BigFraction>() {new BigFraction(new BigNum("254355652346"), new BigNum("65435342242"))},
						new Polynomial(BigNum.Zero, new List<BigFraction>(){new BigFraction(BigNum.Zero)})
                    },

					new object[]
					{
						new BigNum("6"),
						new List<BigFraction>() { new BigFraction(new BigNum("6456456"), new BigNum("23424")),new BigFraction(new BigNum("23426"), new BigNum("756767")),new BigFraction(new BigNum("97886"), new BigNum("2345241")),new BigFraction(new BigNum("12313"), new BigNum("5345")),new BigFraction(new BigNum("6456"), new BigNum("2342335")),new BigFraction(new BigNum("756"), new BigNum("2346")),new BigFraction(new BigNum("23"), new BigNum("534")), },
						new Polynomial(new BigNum("5"),new List<BigFraction>(){new BigFraction(new BigNum("23426"), new BigNum("756767")),new BigFraction(new BigNum("195772"), new BigNum("2345241")),new BigFraction(new BigNum("36939"), new BigNum("5345")),new BigFraction(new BigNum("25824"), new BigNum("2342335")),new BigFraction(new BigNum("3780"), new BigNum("2346")),new BigFraction(new BigNum("138"), new BigNum("534")),})
					},
					new object[]
					{
						new BigNum("20"),
						new List<BigFraction>() { new BigFraction(new BigNum("53535353535345345"), new BigNum("76675666545")),new BigFraction(new BigNum("24234324"), new BigNum("4523")),new BigFraction(new BigNum("123123"), new BigNum("6453")),new BigFraction(new BigNum("123142"), new BigNum("6454")),new BigFraction(new BigNum("123245"), new BigNum("4532")),new BigFraction(new BigNum("123125"), new BigNum("756643")),new BigFraction(new BigNum("23425"), new BigNum("453")),new BigFraction(new BigNum("2423645"), new BigNum("7566453")),new BigFraction(new BigNum("234242353"), new BigNum("76546534535")),new BigFraction(new BigNum("2342235"), new BigNum("7564")),new BigFraction(new BigNum("23324"), new BigNum("765453")),new BigFraction(new BigNum("23425"), new BigNum("568886")),new BigFraction(new BigNum("2342536"),new BigNum("876545654")),new BigFraction(new BigNum("234645"), new BigNum("86756434")),new BigFraction(new BigNum("324254"), new BigNum("867543")),new BigFraction(new BigNum("-2342334345546"), new BigNum("8675545")),new BigFraction(new BigNum("0"), new BigNum("4575755")),new BigFraction(new BigNum("0"), new BigNum("23424")),new BigFraction(new BigNum("0"), new BigNum("7565")),new BigFraction(new BigNum("-23424"), new BigNum("645433")),new BigFraction(new BigNum("23435"), new BigNum("6646")), },
						new Polynomial(new BigNum("19"),new List<BigFraction>(){new BigFraction(new BigNum("24234324"), new BigNum("4523")),new BigFraction(new BigNum("246246"), new BigNum("6453")),new BigFraction(new BigNum("369426"), new BigNum("6454")),new BigFraction(new BigNum("492980"), new BigNum("4532")),new BigFraction(new BigNum("615625"), new BigNum("756643")),new BigFraction(new BigNum("140550"), new BigNum("453")),new BigFraction(new BigNum("16965515"), new BigNum("7566453")),new BigFraction(new BigNum("1873938824"), new BigNum("76546534535")),new BigFraction(new BigNum("21080115"), new BigNum("7564")),new BigFraction(new BigNum("233240"), new BigNum("765453")),new BigFraction(new BigNum("257675"), new BigNum("568886")),new BigFraction(new BigNum("28110432"), new BigNum("876545654")),new BigFraction(new BigNum("3050385"), new BigNum("86756434")),new BigFraction(new BigNum("4539556"), new BigNum("867543")),new BigFraction(new BigNum("-35135015183190"), new BigNum("8675545")),new BigFraction(new BigNum("0"), new BigNum("4575755")),new BigFraction(new BigNum("0"), new BigNum("23424")),new BigFraction(new BigNum("0"),new BigNum("7565")),new BigFraction(new BigNum("-445056"), new BigNum("645433")),new BigFraction(new BigNum("468700"), new BigNum("6646")),})
					},
					new object[]
					{
						new BigNum("3"),
						new List<BigFraction>() { new BigFraction(new BigNum("5353"), new BigNum("1235")),new BigFraction(new BigNum("-5345"), new BigNum("234")),new BigFraction(new BigNum("645"), new BigNum("234")),new BigFraction(new BigNum("-536"), new BigNum("2345")), },
						new Polynomial(new BigNum("2"),new List<BigFraction>(){new BigFraction(new BigNum("-5345"), new BigNum("234")),new BigFraction(new BigNum("1290"), new BigNum("234")),new BigFraction(new BigNum("-1608"), new BigNum("2345")),})
					},
					new object[]
					{
						new BigNum("5"),
						new List<BigFraction>() { new BigFraction(new BigNum("8574645634"), new BigNum("243325645636675")),new BigFraction(new BigNum("3253542342364645645325"), new BigNum("763532")),new BigFraction(new BigNum("-123144355"), new BigNum("53455")),new BigFraction(new BigNum("234334"), new BigNum("13123")),new BigFraction(new BigNum("6544"), new BigNum("12313")),new BigFraction(new BigNum("345"), new BigNum("123543")), },
						new Polynomial(new BigNum("4"),new List<BigFraction>(){new BigFraction(new BigNum("3253542342364645645325"), new BigNum("763532")),new BigFraction(new BigNum("-246288710"), new BigNum("53455")),new BigFraction(new BigNum("703002"), new BigNum("13123")),new BigFraction(new BigNum("26176"), new BigNum("12313")),new BigFraction(new BigNum("1725"), new BigNum("123543")),})
					},
					new object[]
					{
						new BigNum("8"),
						new List<BigFraction>() { new BigFraction(new BigNum("7567464345353523"), new BigNum("234233434646")),new BigFraction(new BigNum("454242234"), new BigNum("1231312345")),new BigFraction(new BigNum("-12312"), new BigNum("53543")),new BigFraction(new BigNum("-123124"), new BigNum("665765")),new BigFraction(new BigNum("0"), new BigNum("456465")),new BigFraction(new BigNum("23421"), new BigNum("7565")),new BigFraction(new BigNum("75675"), new BigNum("2343234")),new BigFraction(new BigNum("23444"), new BigNum("654")),new BigFraction(new BigNum("-23424"), new BigNum("6546")), },
						new Polynomial(new BigNum("7"),new List<BigFraction>(){new BigFraction(new BigNum("454242234"), new BigNum("1231312345")),new BigFraction(new BigNum("-24624"), new BigNum("53543")),new BigFraction(new BigNum("-369372"), new BigNum("665765")),new BigFraction(new BigNum("0"), new BigNum("456465")),new BigFraction(new BigNum("117105"), new BigNum("7565")),new BigFraction(new BigNum("454050"), new BigNum("2343234")),new BigFraction(new BigNum("164108"),new BigNum("654")),new BigFraction(new BigNum("-187392"), new BigNum("6546")),})
					},
				};

	}
}