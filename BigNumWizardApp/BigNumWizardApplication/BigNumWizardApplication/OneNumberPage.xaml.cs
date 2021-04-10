using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Navigation;
using System;
using Windows.UI.Popups;
using Microsoft.UI.Xaml;

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
        public static string Value { get; set; } = "0";

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
                textBox.Text = func(Value);
            }
            catch (Exception e)
            {
                var messageDialog = new MessageDialog(e.Message.ToString());
                await messageDialog.ShowAsync();
            }

        }
/*        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            func = (TargetFunctionDelegate)e.Parameter;
        } */
    }
}