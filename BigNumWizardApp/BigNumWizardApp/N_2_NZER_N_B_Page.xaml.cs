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
using Windows.UI.Popups;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace BigNumWizardApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class N_2_NZER_N_B_Page
    {
        private string Value { get; set; } = "";
        public N_2_NZER_N_B_Page()
        {
            this.InitializeComponent();

            numberBox.TextChanged += NumberBox_TextChanged;
            
        }

        async private void NumberBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (numberBox.Text != "")
            {
                TextBox box = sender as TextBox;
                try
                {
                    int s = Convert.ToInt32(box.Text.Substring(box.Text.Length - 1));
                    Value = box != null ? box.Text : Value;
                    var num = new BigNum(Value);
                    textBox.Text = N2_6.NZER_N_B(num);
                }
                catch (System.FormatException)
                {
                    var dialog = new MessageDialog("Вы ввели символ! Пожалуйста,введите цифрy");
                    await dialog.ShowAsync();
                    box.Text = Value == "" ? "" : Value;
                }
            } 
            else
            {
                textBox.Text = "Тут будет ответ"; 
            } 
            
        }


    }
}
