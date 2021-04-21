 using BigNumWizardShared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace BigNumWizardUWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class OnePolynomPage : Page
    {
        public delegate Polynomial TargetFunctionDelegate(string param);
        private TargetFunctionDelegate func;

        private string Value1 { get; set; } = "0";
        private static string allowedChar { get; } = "0123456789-/ ";
        private Regex rgx = new Regex(@"^(-?\d*(\/\d+)?\s)*$");

        public OnePolynomPage()
        {
            this.InitializeComponent();
            
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
                if (!Value1.All(allowedChar.Contains))
                {
                    var messageDialog = new MessageDialog("Введены недопустимые символы");
                    await messageDialog.ShowAsync();
                    textBox.Text = "Здесь будет ответ";
                }
                else if (!rgx.IsMatch(Value1 + " "))
                {
                    var messageDialog = new MessageDialog("Введенное число в одном из полей некорректно");
                    await messageDialog.ShowAsync();
                }
                else textBox.Text = CastingOddsToString(func(Value1).Odds);
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
            func = (TargetFunctionDelegate)e.Parameter;
        }


        private string CastingOddsToString(List<BigFraction> fractionOdds)
        {
            var listStringOdds = new List<string>();
            foreach (BigFraction fractionOdd in fractionOdds)
            {
                if (fractionOdd.Denom == BigNum.One || fractionOdd.Nom == BigNum.Zero)
                {
                    listStringOdds.Add(fractionOdd.Nom.ToString());
                }
                else
                {
                    listStringOdds.Add(fractionOdd.Nom.ToString() + "/" + fractionOdd.Denom.ToString());
                }
            }

            string stringOdds = "";

            foreach (string stringOdd in listStringOdds)
            {
                stringOdds += stringOdd + " ";
            }

            return stringOdds;
        }
    }
}
