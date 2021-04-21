using BigNumWizardShared;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text.RegularExpressions;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace BigNumWizardUWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class TwoFractionsPage : Page
    {
        public delegate BigFraction TargetFunctionDelegate(string fir_nom, string fir_denom, 
                                                            string sec_nom, string sec_denom);

        private TargetFunctionDelegate func;
        public static string Value1 { get; set; } = "0";
        public static string Value2 { get; set; } = "1";
        public static string Value3 { get; set; } = "0";
        public static string Value4 { get; set; } = "1";
        private static string allowedChar { get; } = "0123456789-";
        private Regex rgx = new Regex(@"^-?\d*$");

        public TwoFractionsPage()
        {
            this.InitializeComponent();
            numberBox1.TextChanged += NumberBox1_TextChanged;
            numberBox2.TextChanged += NumberBox2_TextChanged;
            numberBox3.TextChanged += NumberBox3_TextChanged;
            numberBox4.TextChanged += NumberBox4_TextChanged;
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

        private void NumberBox3_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox box = sender as TextBox;
            Value3 = box != null ? box.Text : Value3;
        }

        private void NumberBox4_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox box = sender as TextBox;
            Value4 = box != null ? box.Text : Value4;
        }

        private async void ButtonResult_Clicked(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!Value1.All(allowedChar.Contains) || !Value2.All(allowedChar.Contains) ||
                    !Value3.All(allowedChar.Contains) || !Value4.All(allowedChar.Contains))
                {
                    var messageDialog = new MessageDialog("Введены недопустимые символы");
                    await messageDialog.ShowAsync();
                }
                else if (!rgx.IsMatch(Value1) || !rgx.IsMatch(Value2) ||
                    !rgx.IsMatch(Value3) || !rgx.IsMatch(Value4))
                {
                    var messageDialog = new MessageDialog("Введенное число в одном из полей некорректно");
                    await messageDialog.ShowAsync();
                }
                else
                {
                    var result = func(Value1, Value2, Value3, Value4);
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
