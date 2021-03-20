using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using BigNumWizardShared;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace BigNumWizardApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private string Value1 { get; set; } = "0";
        private string Value2 { get; set; } = "0";
        public MainPage()
        {
            this.InitializeComponent();
			numberBox1.TextChanged += NumberBox1_TextChanged;
			numberBox2.TextChanged += NumberBox2_TextChanged;
        }

		private void NumberBox2_TextChanged(object sender, TextChangedEventArgs e)
		{
            TextBox box = sender as TextBox;
            Value2 = box != null ? box.Text : Value2;
            Summarize();
        }

		private void NumberBox1_TextChanged(object sender, TextChangedEventArgs e)
		{
            TextBox box = sender as TextBox;
            Value1 = box != null ? box.Text : Value1;
            Summarize();
        }

        private void Summarize() {
            var num1 = new BigNum(Value1);
            var num2 = new BigNum(Value2);
            textBlock.Text = (string)(num1 + num2);
        }
    }
}
