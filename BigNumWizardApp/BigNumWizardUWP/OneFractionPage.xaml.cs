using BigNumWizardShared;
using System;
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
    public sealed partial class OneFractionPage : Page
    {
        public delegate BigFraction TargetFunctionDelegate(string param1, string param2);

        private TargetFunctionDelegate func;
        private static string Value1 { get; set; } = "0";
        private static string Value2 { get; set; } = "1";
        private static string allowedChar { get; } = "0123456789-";
        private Regex rgx = new Regex(@"^-?\d*$");

        public OneFractionPage()
        {
            this.InitializeComponent();
            numberBox1.TextChanged += NumberBox1_TextChanged;
            numberBox2.TextChanged += NumberBox2_TextChanged;
            buttonResult.Click += ButtonResult_Clicked;

        }

        private void NumberBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox box = sender as TextBox;
            Value1 = box != null ? box.Text : Value1;
        }

        private void NumberBox2_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox box = sender as TextBox;
            Value2 = box != null ? box.Text : Value2;
        }

        private async void ButtonResult_Clicked(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!Value1.All(allowedChar.Contains) || !Value2.All(allowedChar.Contains))
                {
                    var messageDialog = new MessageDialog("Введены недопустимые символы");
                    await messageDialog.ShowAsync();
                }
                else if (!rgx.IsMatch(Value1) || !rgx.IsMatch(Value2))
                {
                    var messageDialog = new MessageDialog("Введенное число в одном из полей некорректно");
                    await messageDialog.ShowAsync();
                }
                else
                {
                    var result = func(Value1, Value2);
                    numberBox3.Text = result.Nom.ToString() == "0" ? result.Nom.ToString() : getSign(result.Positive) + result.Nom.ToString();
                    numberBox4.Text = result.Denom.ToString();
                }
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
