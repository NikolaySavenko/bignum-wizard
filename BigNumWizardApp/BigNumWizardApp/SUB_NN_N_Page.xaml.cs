using BigNumWizardShared;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Microsoft.UI.Xaml.Controls;
using System.Text.RegularExpressions;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace BigNumWizardApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SUB_NN_N_Page
    {
        private string Value1 { get; set; } = "";
        private string Value2 { get; set; } = "";
        public SUB_NN_N_Page()
        {
            this.InitializeComponent();
            numberBox1.TextChanged += NumberBox1_TextChanged1;
            numberBox2.TextChanged += NumberBox2_TextChanged1;
        }

        private void NumberBox2_TextChanged1(object sender, TextChangedEventArgs e)
        {
            TextBox box = sender as TextBox;
            Value2 = box != null ? box.Text : Value2;
            Summarize();
        }

        private void NumberBox1_TextChanged1(object sender, TextChangedEventArgs e)
        {
            TextBox box = sender as TextBox;
            Value1 = box != null ? box.Text : Value1;
            Summarize();
        }

        private void Summarize()
        {
            var num1 = new BigNum(Value1);
            var num2 = new BigNum(Value2);
            textBox.Text = (string)(num1 - num2);
        }
    }
}


