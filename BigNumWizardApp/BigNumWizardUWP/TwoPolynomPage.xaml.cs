using BigNumWizardShared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using static BigNumWizardUWP.NavigationParametrData;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace BigNumWizardUWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class TwoPolynomPage : Page
    {


        private TargetFunctionDelegate func;

        private string Value1 { get; set; } = "0";
        public static string Value2 { get; set; } = "1";
        private static string allowedChar { get; } = "0123456789-/ ";
        private Regex rgx = new Regex(@"^(-?\d+(\/\d+)?\s)*$");

        public TwoPolynomPage()
        {
            this.InitializeComponent();
        }

        private void NumberBox2_TextChanged1(object sender, TextChangedEventArgs e)
        {
            TextBox box = sender as TextBox;
            Value2 = box != null ? box.Text : Value2;
        }

        private void NumberBox1_TextChanged1(object sender, TextChangedEventArgs e)
        {
            TextBox box = sender as TextBox;
            Value1 = box != null ? box.Text : Value1;
        }


        private async void ButtonResult_Clicked(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!Value1.All(allowedChar.Contains) || !Value2.All(allowedChar.Contains))
                {
                    var messageDialog = new MessageDialog("Введены недопустимые символы");
                    await messageDialog.ShowAsync();
                    Value1 = "0";
                    textBox.Text = "Здесь будет ответ";
                }
                else if (!rgx.IsMatch(Value1 + " ") || !rgx.IsMatch(Value2 + " "))
                {
                    var messageDialog = new MessageDialog("Введенное число в одном из полей некорректно");
                    await messageDialog.ShowAsync();
                }
                else textBox.Text = CastingOddsToString(func(Value1, Value2).Odds);
            }
            catch (Exception err)
            {
                var messageDialog = new MessageDialog(err.Message.ToString());
                await messageDialog.ShowAsync();
            }
        }


        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            NavigationParametrData dataType = (NavigationParametrData)e.Parameter;
            func = dataType.Function;
            numberBox2.Header = dataType.NumberBoxHeader;
        }


        private string CastingOddsToString(List<BigFraction> fractionOdds)
        {
            var listStringOdds = new List<string>(); 
            foreach (BigFraction fractionOdd in fractionOdds)
            {
                if (fractionOdd.Denom == BigNum.One || fractionOdd.Nom == BigNum.Zero)
                {
                    listStringOdds.Add(fractionOdd.Nom.ToString() != "0" ? getSign(fractionOdd.Positive) + fractionOdd.Nom.ToString() : fractionOdd.Nom.ToString());
                }
                else
                {
                    listStringOdds.Add(getSign(fractionOdd.Positive) + fractionOdd.Nom.ToString() + "/" + fractionOdd.Denom.ToString());
                }
            }

            string stringOdds = "";

            foreach (string stringOdd in listStringOdds)
            {
                stringOdds += stringOdd + " ";
            }

            return stringOdds;
        }

        private string getSign(bool isPositive)
        {
            string sign = "";
            if (!isPositive)
            {
                sign = "-";
            }
            return sign;
        }
    }
}
