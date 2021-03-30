using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using BigNumWizardShared;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Navigation;
using Windows.UI.Popups;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace BigNumWizardApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class TwoNumbersPage : Page
    {
        public delegate string TargetFunctionDelegate(string param1, string param2);

        private TargetFunctionDelegate func;

        private string Value1 { get; set; } = "0";
        public static string Value2 { get; set; } = "0";

        public TwoNumbersPage()
        {
            this.InitializeComponent();
            numberBox1.TextChanged += NumberBox1_TextChanged1;
            numberBox2.TextChanged += NumberBox2_TextChanged1;
            
        }

        private void NumberBox2_TextChanged1(object sender, TextChangedEventArgs e)
        {
            TextBox box = sender as TextBox;
            Value2 = box != null ? box.Text : Value2;
            IvokeAction();
        }

        private void NumberBox1_TextChanged1(object sender, TextChangedEventArgs e)
        {
            TextBox box = sender as TextBox;
            Value1 = box != null ? box.Text : Value1;
            IvokeAction();
        }

        async private void IvokeAction()
        {
            try
            {
                textBox.Text = func(Value1, Value2);
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