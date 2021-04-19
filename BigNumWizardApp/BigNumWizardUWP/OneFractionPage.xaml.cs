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
                    Value1 = "0";
                    Value2 = "1";
                }
                else
                {
                    numberBox3.Text = func(Value1, Value2).Nom.ToString();
                    numberBox4.Text = func(Value1, Value2).Denom.ToString();
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
    }
}
