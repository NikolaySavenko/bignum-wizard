using BigNumWizardShared;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace BigNumWizardApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Z2_POZ_Z_D_Page
    {
        private string Value { get; set; } = "";
        public Z2_POZ_Z_D_Page()
        {
            this.InitializeComponent();
            numberBox.TextChanged += NumberBox_TextChanged;
        }


        private void NumberBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox box = sender as TextBox;
            Value = box != null ? box.Text : Value;
            var num = new BigNum(Value);
            textBox.Text = (z2_3.POZ_Z_D(num)).ToString();

        }
    }
}






