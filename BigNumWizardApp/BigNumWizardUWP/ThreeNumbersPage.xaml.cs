

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

using BigNumWizardShared;
using System;
using System.Linq;
using System.Text.RegularExpressions;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace BigNumWizardApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ThreeNumbersPage : Page
    {
        public delegate string TargetFunctionDelegate(string param1, string param2, string param3);

        private TargetFunctionDelegate func;

        private static string Value1 { get; set; } = "0";
        private static string Value2 { get; set; } = "0";
        private static string Value3 { get; set; } = "0";
        private static string allowedChar { get; } = "0123456789";
        private Regex rgx = new Regex(@"^-?\d*$");

        public ThreeNumbersPage()
        {
            this.InitializeComponent();
            numberBox1.TextChanged += NumberBox1_TextChanged1;
            numberBox2.TextChanged += NumberBox2_TextChanged1;
            numberBox3.TextChanged += NumberBox3_TextChanged1;

        }

        private void NumberBox2_TextChanged1(object sender, TextChangedEventArgs e)
        {
            TextBox box = sender as TextBox;
            Value2 = box != null ? box.Text : Value2;
        }

        private void NumberBox3_TextChanged1(object sender, TextChangedEventArgs e)
        {
            TextBox box = sender as TextBox;
            Value3 = box != null ? box.Text : Value3;
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
                if (!Value1.All(allowedChar.Contains) || !Value2.All(allowedChar.Contains) || !Value3.All(allowedChar.Contains))
                {
                    var messageDialog = new MessageDialog("Введены недопустимые символы");
                    await messageDialog.ShowAsync();
                    ResetParams();
                }
                else if (new BigNum(Value3) >= BigNum.Ten)
                {
                    var messageDialog = new MessageDialog("В поле номер 3 может быть введена только цифра");
                    await messageDialog.ShowAsync();
                    Value3 = "0";
                    textBox.Text = "Здесь будет ответ";
                }
                else if (!rgx.IsMatch(Value1) || !rgx.IsMatch(Value2) || !rgx.IsMatch(Value3))
                {

                }
                else textBox.Text = func(Value1, Value2, Value3);
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

        private void ResetParams()
        {
            Value1 = Value2 = Value3 = "0";
            numberBox1.Text = numberBox2.Text = numberBox3.Text = "";
            textBox.Text = "Здесь будет ответ";
        }
    }
}