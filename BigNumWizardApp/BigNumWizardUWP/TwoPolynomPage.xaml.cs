using BigNumWizardShared;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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
        public static string Value2 { get; set; } = "0";

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
                textBox.Text = CastingOddsToString(func(Value1, Value2).Odds);
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
