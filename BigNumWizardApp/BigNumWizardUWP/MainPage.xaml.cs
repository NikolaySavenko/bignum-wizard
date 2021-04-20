using BigNumWizardApp;
using BigNumWizardShared;
using System.Collections.Generic;
using Windows.Foundation;
using Windows.UI.Xaml.Controls;

namespace BigNumWizardUWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        public MainPage()
        {
            this.InitializeComponent();
        }


        private void OnNavigationViewItemInvoked(Microsoft.UI.Xaml.Controls.NavigationView sender, Microsoft.UI.Xaml.Controls.NavigationViewItemInvokedEventArgs args)
        {

            if (args.InvokedItemContainer.IsSelected)
            {
                // Clicked on an item that is already selected,
                // Avoid navigating to the same page again causing movement.
                return;
            }
            else
            {
                var invokedItem = args.InvokedItemContainer;

                if (invokedItem.Tag != null)
                {
                    switch (invokedItem.Tag.ToString())
                    {
                        case "PageSum":
                            TwoNumbersPage.TargetFunctionDelegate actionSum = (string param1, string param2) =>
                            {
                                return Z6.ADD_ZZ_Z(new BigNum(param1), new BigNum(param2)).ToString();
                            };
                            ContentFrame.Navigate(typeof(TwoNumbersPage), actionSum);
                            nvMain.Header = "Сложение";
                            break;
                        case "PageSub":
                            TwoNumbersPage.TargetFunctionDelegate actionSub = (string param1, string param2) =>
                            {
                                return Z7.SUB_ZZ_Z(new BigNum(param1), new BigNum(param2)).ToString();
                            };
                            ContentFrame.Navigate(typeof(TwoNumbersPage), actionSub);
                            nvMain.Header = "Вычитание";
                            break;
                        case "PageMultiply":
                            TwoNumbersPage.TargetFunctionDelegate actionMultiply = (string param1, string param2) =>
                            {
                                return Z8.MUL_ZZ_Z(new BigNum(param1), new BigNum(param2)).ToString();
                            };

                            ContentFrame.Navigate(typeof(TwoNumbersPage), actionMultiply);
                            nvMain.Header = "Умножение";
                            break;
                        case "PageDivide":
                            TwoNumbersPage.TargetFunctionDelegate actionDivide = (string param1, string param2) =>
                            {
                                var remainer = new BigNum();
                                return Z9.DIV_ZZ_Z(new BigNum(param1), new BigNum(param2), out remainer).ToString();
                            };
                            ContentFrame.Navigate(typeof(TwoNumbersPage), actionDivide);
                            nvMain.Header = "Частное от деления";
                            break;
                        case "PageRemainer":
                            TwoNumbersPage.TargetFunctionDelegate actionRemainer = (string param1, string param2) =>
                            {
                                var remainer = new BigNum();
                                Z9.DIV_ZZ_Z(new BigNum(param1), new BigNum(param2), out remainer);
                                return remainer.ToString();
                            };
                            ContentFrame.Navigate(typeof(TwoNumbersPage), actionRemainer);
                            nvMain.Header = "Остаток от деления";
                            break;
                        case "PageComparison":
                            TwoNumbersPage.TargetFunctionDelegate actionComparison = (string param1, string param2) =>
                            {
                                var result = Natural1_5.COM_NN_D(new BigNum(param1), new BigNum(param2)).ToString();
                                if (result == "2") { result = "Первое больше"; }
                                else if (result == "0") { result = "Числа равны"; }
                                else { result = "Второе больше"; }
                                return result;
                            };
                            ContentFrame.Navigate(typeof(TwoNumbersPage), actionComparison);
                            nvMain.Header = "Сравнение";
                            break;
                        case "PageN9":
                            ThreeNumbersPage.TargetFunctionDelegate actionN9 = (string param1, string param2, string param3) =>
                            {
                                byte value = param3 != "" ? byte.Parse(param3) : (byte)0;
                                return N9.SUB_NDN_N(new BigNum(param1), new BigNum(param2), value).ToString();
                            };
                            ContentFrame.Navigate(typeof(ThreeNumbersPage), actionN9);
                            nvMain.Header = "Подмодуль N9";
                            break;
                        case "PageCheckZero":
                            OneNumberPage.TargetFunctionDelegate actionCheckZero = (string param1) =>
                            {
                                var result = N2_6.NZER_N_B(new BigNum(param1));
                                return result == "yes" ? "Число не равно нулю" : "Число равно нулю";
                            };
                            ContentFrame.Navigate(typeof(OneNumberPage), actionCheckZero);
                            nvMain.Header = "Проверка на ноль";
                            break;
                        case "PagePoz":
                            OneNumberPage.TargetFunctionDelegate actionPoz = (string param1) =>
                            {
                                var result = z2_3.POZ_Z_D(new BigNum(param1));
                                if (result == 2) return "Положительное";
                                else if (result == 0) return "Равно нулю"; 
                                else return "Отрицательное";
                            };
                            ContentFrame.Navigate(typeof(OneNumberPage), actionPoz);
                            nvMain.Header = "'Положительность' числа";
                            break;
                        case "PageNOD":
                            TwoNumbersPage.TargetFunctionDelegate actionNOD = (string param1, string param2) =>
                            {
                         
                                return N4_13.GCF_NN_N(new BigNum(param1), new BigNum(param2)).ToString();
                            };
                            ContentFrame.Navigate(typeof(TwoNumbersPage), actionNOD);
                            nvMain.Header = "НОД чисел";
                            break;
                        case "PageNOK":
                            TwoNumbersPage.TargetFunctionDelegate actionNOK = (string param1, string param2) =>
                            {

                                return N8_14.LCM_NN_N(new BigNum(param1), new BigNum(param2)).ToString();
                            };
                            ContentFrame.Navigate(typeof(TwoNumbersPage), actionNOK);
                            nvMain.Header = "НОК чисел";
                            break;
                        case "PageFractionReduction":
                            OneFractionPage.TargetFunctionDelegate actionFractionReduction = (string param1, string param2) =>
                            {

                                return Q1.RED_Q_Q(new BigFraction(new BigNum(param1), new BigNum(param2)));
                            };
                            ContentFrame.Navigate(typeof(OneFractionPage), actionFractionReduction);
                            nvMain.Header = "Сокращение дроби";
                            break;
                        case "PageFractionSum":
                            TwoFractionsPage.TargetFunctionDelegate actionFractionSum = (string param1, string param2, string param3, string param4) =>
                            {

                                return Q5_7.ADD_QQ_Q(new BigFraction(new BigNum(param1), new BigNum(param2)),
                                                     new BigFraction(new BigNum(param3), new BigNum(param4)));
                            };
                            ContentFrame.Navigate(typeof(TwoFractionsPage), actionFractionSum);
                            nvMain.Header = "Сложение дробей";
                            break;
                        case "PageFractionSub":
                            TwoFractionsPage.TargetFunctionDelegate actionFractionSub = (string param1, string param2, string param3, string param4) =>
                            {

                                return Q6.SUB_QQ_Q(new BigFraction(new BigNum(param1), new BigNum(param2)),
                                                     new BigFraction(new BigNum(param3), new BigNum(param4)));
                            };
                            ContentFrame.Navigate(typeof(TwoFractionsPage), actionFractionSub);
                            nvMain.Header = "Вычитание дробей";
                            break;
                        case "PageFractionMul":
                            TwoFractionsPage.TargetFunctionDelegate actionFractionMul = (string param1, string param2, string param3, string param4) =>
                            {

                                return Q5_7.MUL_QQ_Q(new BigFraction(new BigNum(param1), new BigNum(param2)),
                                                     new BigFraction(new BigNum(param3), new BigNum(param4)));
                            };
                            ContentFrame.Navigate(typeof(TwoFractionsPage), actionFractionMul);
                            nvMain.Header = "Умножение дробей";
                            break;
                        case "PageFractionDiv":
                            TwoFractionsPage.TargetFunctionDelegate actionFractionDiv = (string param1, string param2, string param3, string param4) =>
                            {

                                return Q8.DIV_QQ_Q(new BigFraction(new BigNum(param1), new BigNum(param2)),
                                                     new BigFraction(new BigNum(param3), new BigNum(param4)));
                            };
                            ContentFrame.Navigate(typeof(TwoFractionsPage), actionFractionDiv);
                            nvMain.Header = "Деление дробей";
                            break;
                        case "PagePolynomSum":
                            NavigationParametrData.TargetFunctionDelegate actionPolynomSum = (string param1, string param2) =>
                            {
                                var param1Casted = CastingStringToPolynom(param1);
                                var param2Casted = CastingStringToPolynom(param2);
                                return P1_2.ADD_PP_P(param1Casted.SeniorDegree, param1Casted.Odds, 
                                                    param2Casted.SeniorDegree, param2Casted.Odds);
                            };
                            ContentFrame.Navigate(typeof(TwoPolynomPage), new NavigationParametrData(actionPolynomSum, "Коэффициенты второго многочлена"));
                            nvMain.Header = "Сложение многочленов";
                            break;
                        case "PagePolynomSub":
                            NavigationParametrData.TargetFunctionDelegate actionPolynomSub = (string param1, string param2) =>
                            {
                                var param1Casted = CastingStringToPolynom(param1);
                                var param2Casted = CastingStringToPolynom(param2);
                                return P1_2.SUB_PP_P(param1Casted.SeniorDegree, param1Casted.Odds,
                                                    param2Casted.SeniorDegree, param2Casted.Odds);
                            };
                            ContentFrame.Navigate(typeof(TwoPolynomPage), new NavigationParametrData(actionPolynomSub, "Коэффициенты второго многочлена"));
                            nvMain.Header = "Вычитание многочленов";
                            break;
                        case "PagePolynomMulFraction":
                            NavigationParametrData.TargetFunctionDelegate actionPolynomMulFraction = (string param1, string param2) =>
                            {
                                var param1Casted = CastingStringToPolynom(param1);
                                var param2BigFrac = CastingStringToBigFraction(param2);
                                return P3.MUL_PQ_P(param1Casted.SeniorDegree, param1Casted.Odds, param2BigFrac);
                            };
                            ContentFrame.Navigate(typeof(TwoPolynomPage), new NavigationParametrData(actionPolynomMulFraction, "Рациональное число"));
                            nvMain.Header = "Умножение многочлена на рациональное число";
                            break;
                        case "PagePolynomMulXK":
                            NavigationParametrData.TargetFunctionDelegate actionPolynomMulXK = (string param1, string param2) =>
                            {
                                var param1Casted = CastingStringToPolynom(param1);
                                return P4_5.MUL_Pxk_P(param1Casted.SeniorDegree, param1Casted.Odds, new BigNum(param2));
                            };
                            ContentFrame.Navigate(typeof(TwoPolynomPage), new NavigationParametrData(actionPolynomMulXK, "k (степень x)"));
                            nvMain.Header = "Умножение многочлена на рациональное число";
                            break;
                        case "PagePolynomsMul":
                            NavigationParametrData.TargetFunctionDelegate actionPolynomsMul = (string param1, string param2) =>
                            {
                                var param1Casted = CastingStringToPolynom(param1);
                                var param2Casted = CastingStringToPolynom(param2);
                                return P8.MUL_PP_P(param1Casted.SeniorDegree, param1Casted.Odds, param2Casted.SeniorDegree, param2Casted.Odds);
                            };
                            ContentFrame.Navigate(typeof(TwoPolynomPage), new NavigationParametrData(actionPolynomsMul, "Коэффициенты второго многочлена"));
                            nvMain.Header = "Умножение многочленов";
                            break;
                        case "PagePolynomsDiv":
                            NavigationParametrData.TargetFunctionDelegate actionPolynomsDiv = (string param1, string param2) =>
                            {
                                var param1Casted = CastingStringToPolynom(param1);
                                var param2Casted = CastingStringToPolynom(param2);
                                return P9.DIV_PP_P(param1Casted.SeniorDegree, param1Casted.Odds, param2Casted.SeniorDegree, param2Casted.Odds);
                            };
                            ContentFrame.Navigate(typeof(TwoPolynomPage), new NavigationParametrData(actionPolynomsDiv, "Коэффициенты второго многочлена"));
                            nvMain.Header = "Частное от деления многочленов";
                            break;
                        case "PagePolynomsReduction":
                            NavigationParametrData.TargetFunctionDelegate actionPolynomsReduction = (string param1, string param2) =>
                            {
                                var param1Casted = CastingStringToPolynom(param1);
                                var param2Casted = CastingStringToPolynom(param2);
                                return P10.MOD_PP_P(param1Casted.SeniorDegree, param1Casted.Odds, param2Casted.SeniorDegree, param2Casted.Odds);
                            };
                            ContentFrame.Navigate(typeof(TwoPolynomPage), new NavigationParametrData(actionPolynomsReduction, "Коэффициенты второго многочлена"));
                            nvMain.Header = "Остаток от деления многочленов";
                            break;
                        case "PagePolynomsNod":
                            NavigationParametrData.TargetFunctionDelegate actionPolynomsNod = (string param1, string param2) =>
                            {
                                var param1Casted = CastingStringToPolynom(param1);
                                var param2Casted = CastingStringToPolynom(param2);
                                return P11.GCF_PP_P(param1Casted.SeniorDegree, param1Casted.Odds, param2Casted.SeniorDegree, param2Casted.Odds);
                            };
                            ContentFrame.Navigate(typeof(TwoPolynomPage), new NavigationParametrData(actionPolynomsNod, "Коэффициенты второго многочлена"));
                            nvMain.Header = "НОД многочленов";
                            break;
                        case "PagePolynomsDerivative":
                            OnePolynomPage.TargetFunctionDelegate actionPolynomsDerivative = (string param) =>
                            {
                                var param1Casted = CastingStringToPolynom(param);
                                return P12.DER_P_P(param1Casted.SeniorDegree, param1Casted.Odds);
                            };
                            ContentFrame.Navigate(typeof(OnePolynomPage), actionPolynomsDerivative);
                            nvMain.Header = "Производная многочлена";
                            break;

                    }
                }
            }
        }

        private void nvMain_Loaded(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            ContentFrame.Navigate(typeof(WelcomePage));
            nvMain.Header = "BigNum Wizard";
        }

        private Polynomial CastingStringToPolynom(string param)
        {
            var listNumbers = new List<string>(param.Split(" "));
            listNumbers = DeleteEmptyLines(listNumbers);
            var odds = new List<BigFraction>();
            foreach (string number in listNumbers)
            {
                if (!number.Contains("/"))
                    odds.Add(new BigFraction(new BigNum(number)));
                else
                {
                    var nomDenom = number.Split("/");
                    odds.Add(new BigFraction(new BigNum(nomDenom[0]), new BigNum(nomDenom[1])));
                }
            }

            var m = new BigNum((odds.Count - 1).ToString());

            var result = new Polynomial(m, odds);

            return result;
        }


        private BigFraction CastingStringToBigFraction(string param)
        {
            BigFraction resultBigFraction;
            if (param.Contains("/"))
            {
                var nomDenom = param.Split("/");
                resultBigFraction = new BigFraction(new BigNum(nomDenom[0]), new BigNum(nomDenom[1]));
            }
            else
            {
                resultBigFraction = new BigFraction(new BigNum(param));
            }

            return resultBigFraction;
        }


        private List<string> DeleteEmptyLines(List<string> listLines)
        {
            while (listLines.Contains(""))
            {
                listLines.Remove("");
            }

            return listLines;
        }

    }
}
