using Xunit;
using BigNumWizardShared;
using System.Collections.Generic;

namespace BigNumWizardTests
{
    public class Test_P8 //Bratsun
    {
        [Theory, MemberData(nameof(Data))]
        public static void Polumn(BigNum m, List<BigFraction> a, BigNum n, List<BigFraction> b, Polynomial res)
        {

            var actual = P8.MUL_PP_P(m, a, n, b);
            Assert.Equal(res, actual);
        }

        public static IEnumerable<object[]> Data
        {
            get
            {
                return new[]
                {
                     new object[] {//true
                        new BigNum("2"),                         //degree
                        new List<BigFraction>() {                //coefficients
                            new BigFraction(new BigNum("45")),   //max degree
                            new BigFraction(new BigNum("35")), 
                            new BigFraction(new BigNum("67"))    //min degree(0)
                        },
                        
                        new BigNum("2"), 
                        new List<BigFraction>() { 
                            new BigFraction(new BigNum("34")), 
                            new BigFraction(new BigNum("98")),
                            new BigFraction(new BigNum("56")) 
                        },
                        
                        new Polynomial
                        (
                            new BigNum("4"), 
                            new List<BigFraction>() { 
                                new BigFraction(new BigNum("1530")),
                                new BigFraction(new BigNum("5600")), 
                                new BigFraction(new BigNum("8228")),
                                new BigFraction(new BigNum("8526")),
                                new BigFraction(new BigNum("3752")) 
                            }
                         ) 
                     },
                     new object[] 
                     {//true
                        new BigNum("2"), 
                        new List<BigFraction>() { 
                            new BigFraction(new BigNum("234555")),
                            new BigFraction(new BigNum("-15850980")),
                            new BigFraction(new BigNum("-16406505"))
                        },
                       
                        new BigNum("3"), 
                        new List<BigFraction>(){ 
                            new BigFraction(new BigNum("31245")),
                            new BigFraction(new BigNum("-6633")), 
                            new BigFraction(new BigNum("271498")),
                            new BigFraction(new BigNum("52632")) 
                        },
                        
                        new Polynomial
                        (
                            new BigNum("5"),
                            new List<BigFraction>() { 
                                new BigFraction(new BigNum("7328670975")),
                                new BigFraction(new BigNum("-496819673415")),
                                new BigFraction(new BigNum("-343800484995")),
                                new BigFraction (new BigNum("-4182339921615")),
                                new BigFraction (new BigNum("-5288602073850")),
                                new BigFraction (new BigNum("-863507171160"))
                            }
                         )
                     },
                     new object[] {//true
                        new BigNum("3"),
                        new List<BigFraction>(){
                            new BigFraction(new BigNum("31245")),
                            new BigFraction(new BigNum("-6633")), 
                            new BigFraction(new BigNum("271498")), 
                            new BigFraction(new BigNum("52632")) 
                        },

                        new BigNum("2"), 
                        new List<BigFraction>() {
                            new BigFraction(new BigNum("234555")),
                            new BigFraction(new BigNum("-15850980")), 
                            new BigFraction(new BigNum("-16406505"))
                        },
                        
                         new Polynomial
                         (
                             new BigNum("5"),
                             new List<BigFraction>() {
                                 new BigFraction(new BigNum("7328670975")),
                                 new BigFraction(new BigNum("-496819673415")), 
                                 new BigFraction(new BigNum("-343800484995")), 
                                 new BigFraction (new BigNum("-4182339921615")),
                                 new BigFraction (new BigNum("-5288602073850")),
                                 new BigFraction (new BigNum("-863507171160"))
                             }
                          )
                    },
                    new object[]
                    {//true
                        new BigNum("5"),
                        new List<BigFraction>() {
                            new BigFraction(new BigNum("-123456789098765431234567890")),
                            new BigFraction(BigNum.Zero), 
                            new BigFraction(BigNum.Zero),
                            new BigFraction(BigNum.Zero), 
                            new BigFraction(BigNum.Zero),
                            new BigFraction(new BigNum("123456789098765431234567890")) 
                        },
                        
                        BigNum.Zero,
                        new List<BigFraction>(){
                            new BigFraction(BigNum.One)
                        },
                        
                        new Polynomial
                        (
                            new BigNum("5"), 
                            new List<BigFraction>() { 
                                new BigFraction(new BigNum("-123456789098765431234567890")),
                                new BigFraction(BigNum.Zero), 
                                new BigFraction(BigNum.Zero),
                                new BigFraction(BigNum.Zero),
                                new BigFraction(BigNum.Zero),
                                new BigFraction(new BigNum("123456789098765431234567890")) 
                            }
                         )
                    },
                    new object[]
                    {//true
                        new BigNum("5"), 
                        new List<BigFraction>() { 
                            new BigFraction(new BigNum("-123456789098765431234567890"), new BigNum("1000000000")),
                            new BigFraction(BigNum.Zero), 
                            new BigFraction(BigNum.Zero),
                            new BigFraction(BigNum.Zero), 
                            new BigFraction(BigNum.Zero),
                            new BigFraction(new BigNum("123456789098765431234567890"))
                        },
                        
                        BigNum.Zero,
                        new List<BigFraction>(){
                            new BigFraction(BigNum.One)
                        },

                        new Polynomial
                        (
                            new BigNum("5"),
                            new List<BigFraction>() { 
                                new BigFraction(new BigNum("-12345678909876543123456789"), new BigNum("100000000")),
                                new BigFraction(BigNum.Zero),
                                new BigFraction(BigNum.Zero),
                                new BigFraction(BigNum.Zero),
                                new BigFraction(BigNum.Zero), 
                                new BigFraction(new BigNum("123456789098765431234567890"))
                            }
                        )
                    },
                    new object[]
                    {//true
                        new BigNum("4"),
                        new List<BigFraction>(){
                            new BigFraction(new BigNum("381219")), 
                            new BigFraction(new BigNum("-5")),
                            new BigFraction(BigNum.Zero),
                            new BigFraction(new BigNum("4221")), 
                            new BigFraction(new BigNum("5")) 
                        },
                        
                        BigNum.Zero,
                        new List<BigFraction>(){ 
                            new BigFraction(new BigNum("3333000"), new BigNum("94000")) },
                        
                        new Polynomial
                        (
                            new BigNum("4"),
                            new List<BigFraction>(){ 
                                new BigFraction(new BigNum("1270602927"), new BigNum("94")), 
                                new BigFraction(new BigNum("-16665"), new BigNum("94")), 
                                new BigFraction(BigNum.Zero),
                                new BigFraction(new BigNum("14068593"), new BigNum ("94")),
                                new BigFraction(new BigNum("16665"), new BigNum ("94")) 
                            }
                        )
                    },
                    new object[]
                    {//true
                        BigNum.One,
                        new List<BigFraction>() { 
                            new BigFraction(new BigNum("-77777777777777777777777777777770"), BigNum.MinusOne), 
                            new BigFraction(new BigNum("-1999999999999999999999990"), new BigNum("666666"))},
                        
                        new BigNum("3"),
                        new List<BigFraction>(){
                            new BigFraction(new BigNum("12345"), new BigNum("-11111111117")),
                            new BigFraction(new BigNum("-5776072822652739171128927333555000000000000000152394910"), new BigNum("1366666667391")),
                            new BigFraction(new BigNum("548666666666666666666666666666661180"), new BigNum("-11111111117")), 
                            new BigFraction(new BigNum("123450"), new BigNum("-11111111117")) 
                        },

                        new Polynomial
                        (
                            new BigNum("4"),
                            new List<BigFraction>() { 
                                new BigFraction(new BigNum("-960166666666666666666666666666570650"), new BigNum("11111111117")),
                                new BigFraction(new BigNum("-16638876265868072275196828572999844390151190970989255339050366347123888888888844989165319475"),
                                new BigNum("50617233360160467")), new BigFraction(new BigNum("274967770826920912910899926342423187084001236643606054047619047618964266797050"),
                                new BigNum("21693100011497343")), new BigFraction(new BigNum("16626262626262626165639744494949328686868686868696567331200"), new BigNum("112233333392817")),
                                new BigFraction(new BigNum("41149999999999999999999794250"), new BigNum("1234566667320987"))
                            }
                         )
                    },
                    new object[]
                    {//true
                        BigNum.One,
                        new List<BigFraction>() { 
                            new BigFraction(new BigNum("214545"), new BigNum("6723")), 
                            new BigFraction(new BigNum("-1577812"), new BigNum("62376325"))
                        },
                        
                        new BigNum("3"),
                        new List<BigFraction>(){
                            new BigFraction(new BigNum("12345"), new BigNum("-21347")), 
                            new BigFraction(new BigNum("-215562326"), new BigNum("6673")),
                            new BigFraction(new BigNum("54866"), new BigNum("-1117")), 
                            new BigFraction(new BigNum("123450"), new BigNum("-1117")) 
                        },
                        
                        new Polynomial
                        (
                            new BigNum("4"),
                            new List<BigFraction>() { 
                                new BigFraction(new BigNum("-294284225"), new BigNum("15946209")), 
                                new BigFraction(new BigNum("-4105410868789020422352146"), new BigNum("3982443390885087315")),
                                new BigFraction(new BigNum("-781828029799232636486"), new BigNum("1041923752194369825")), 
                                new BigFraction(new BigNum("-183499018139536826"), new BigNum("52046743203675")), 
                                new BigFraction(new BigNum("7791235656"), new BigNum("2786974201"))
                            }
                         )
                    },
                    new object[]
                    {//true
                        BigNum.One,
                        new List<BigFraction>() { 
                            new BigFraction(new BigNum("4216"), new BigNum("216428716517265217658712")), 
                            new BigFraction(new BigNum("-1577812"), new BigNum("21782156216218956"))},
                        
                        new BigNum("3"),
                        new List<BigFraction>(){ 
                            new BigFraction(new BigNum("214"), new BigNum("-21347")), 
                            new BigFraction(new BigNum("-214215125214"), new BigNum("215521")),
                            new BigFraction(new BigNum("54866"), new BigNum("1117")),
                            new BigFraction(new BigNum("123450"), new BigNum("-1117")) },
                        
                        new Polynomial
                        (
                            new BigNum("4"),
                            new List<BigFraction>() { 
                                new BigFraction(new BigNum("-112778"), new BigNum("577512976436757575170065633")),
                                new BigFraction(new BigNum("159685448605223155803422972033708408"), new BigNum("225928470828539457306680278650800245327689993009")),
                                new BigFraction(new BigNum("283714123696566167221403591217458725136756"), new BigNum("3940633374174022482652704849283175997111689733")),
                                new BigFraction(new BigNum("-195165120960924289040579779840624"), new BigNum("54852659938113072266545322951589534158319")), 
                                new BigFraction(new BigNum("16231740950"), new BigNum("2027555707793047821"))
                            }
                         )
                    },
                    new object[]
                    {//true
                        new BigNum("9"),
                        new List<BigFraction>() { 
                            new BigFraction(new BigNum("21756128587125789125"), new BigNum("6723")),
                            new BigFraction(new BigNum("-237523862"), new BigNum("22378528")), 
                            new BigFraction(new BigNum("52166")), 
                            new BigFraction(new BigNum("826782921957692"), new BigNum("327587237")),
                            new BigFraction(new BigNum("23683257"), new BigNum("3267876542468345")), 
                            new BigFraction(new BigNum("-32875728"), new BigNum("2364323")),
                            new BigFraction(new BigNum("23758290918235"), new BigNum("32753272819184891246712")), 
                            new BigFraction(new BigNum("7488729218759012"), new BigNum("62376325215122316231898765")),
                            new BigFraction(new BigNum("-15778122145122145216521541312"), new BigNum("62376325215122316231898765")),
                            new BigFraction(new BigNum("-15778122145122145216521541312"), new BigNum("62376325215122316231898765"))
                        },
                        
                        new BigNum("3"),
                        new List<BigFraction>(){ 
                            new BigFraction(new BigNum("12551242132152131"), new BigNum("-21347")),
                            new BigFraction(new BigNum("-2152362141612"), new BigNum("6673")), 
                            new BigFraction(new BigNum("4215125216214"), new BigNum("2315")), 
                            new BigFraction(new BigNum("421216512"), new BigNum("12352314")) 
                        },
                        
                        new Polynomial
                        (
                            new BigNum("12"),
                            new List<BigFraction>() { 
                            new BigFraction(new BigNum("-273066437755252618847535447925375375"), new BigNum("143515881")), 
                            new BigFraction(new BigNum("-414258633447549150684804554447741426804503"), new BigNum("396879660723024816")), 
                            new BigFraction(new BigNum("812043109945092079488952855949264826045256823"), new BigNum("137816462186070367356")), 
                            new BigFraction(new BigNum("-11490203545004074042067427360041050080668611372167797003"), new BigNum("8365032879122415329451730128060762120")),
                            new BigFraction(new BigNum("-73095067894042376852722477529685388294271067199154244947222459"), new BigNum("101650657157000535197341581936176152868573578295")), 
                            new BigFraction(new BigNum("121699297992575691092371536589780350330352495693533654837071036"), new BigNum ("26435778678992068592716319283648029894885447705")),
                            new BigFraction(new BigNum("19789481502893559077835093797233351936710783033045732766022187650699428981536353"), new BigNum("4329291356303091953160801768882508541769762462187452235668018645979800")),
                            new BigFraction(new BigNum("-69569107205354287890135057486810337509429941047713923144531872948894009549195141504145512964479"), new BigNum("2747820581216962433998434501211122440392231810536704274877787781137998552298718312770")),
                            new BigFraction(new BigNum("16257414157068148058694735011092565789474494398322729341288767917247154650755995335581"), new BigNum("109311557800891241527672766238844042458584019023967773671277274521916580")), 
                            new BigFraction(new BigNum("25799667716032820877000561547824842525386088275113674005147854164180847790326488"), new BigNum("173376624832284825604950285301824310476906104343560144391138511725")), 
                            new BigFraction(new BigNum("-751806450869454532955924726990099372915102029882496"), new BigNum("1983759311971648670590554190963308769825")), 
                            new BigFraction(new BigNum("-136918734071948703625780013280128929078600698752"), new BigNum("297281479390326490422681581142411025")), 
                            new BigFraction(new BigNum("-1107667595979717970343448067384090624"), new BigNum("128415325870551399750618393582035"))
                            }
                         )
                    },
                };
            }
        }

    }
}
