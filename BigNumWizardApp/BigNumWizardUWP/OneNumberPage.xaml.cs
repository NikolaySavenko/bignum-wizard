
using System;
using System.Linq;
using System.Text.RegularExpressions;
using Windows.UI.Popups;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace BigNumWizardApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class OneNumberPage : Page
    {
        public delegate string TargetFunctionDelegate(string param);

        private TargetFunctionDelegate func;
        private static string Value { get; set; } = "0";
        private static string allowedChar { get; } = "0123456789-";
        private Regex rgx = new Regex(@"^-?\d*$");

        public OneNumberPage()
        {
            this.InitializeComponent();
            numberBox.TextChanged += NumberBox_TextChanged;

        }

        private void NumberBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox box = sender as TextBox;
            Value = box != null ? box.Text : Value;
            IvokeAction();
        }

        async private void IvokeAction()
        {
            try
            {
                if (Value == "") textBox.Text = "Здесь будет ответ";
                else if (!Value.All(allowedChar.Contains))
                {
                    var messageDialog = new MessageDialog("Введены недопустимые символы");
                    await messageDialog.ShowAsync();
                    textBox.Text = "Здесь будет ответ";
                }
                else if(!rgx.IsMatch(Value))
                {
                    var messageDialog = new MessageDialog("Введенное число в одном из полей некорректно");
                    await messageDialog.ShowAsync();
                    textBox.Text = "Здесь будет ответ";
                }
                else textBox.Text = func(Value);
            }
            catch (Exception e)
            {
                var messageDialog = new MessageDialog(e.Message.ToString());
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