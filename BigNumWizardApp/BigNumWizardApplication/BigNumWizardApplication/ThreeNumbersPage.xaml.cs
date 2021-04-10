﻿using System;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Navigation;
using Windows.UI.Popups;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace BigNumWizardApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ThreeNumbersPage : Page
    {
        public delegate string TargetFunctionDelegate(string param1, string param2, string param3);

        private TargetFunctionDelegate func;

        private string Value1 { get; set; } = "0";
        private static string Value2 { get; set; } = "0";
        private string Value3 { get; set; } = "0";

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
                textBox.Text = func(Value1, Value2, Value3);
            }
            catch (Exception err)
            {
                var messageDialog = new MessageDialog(err.Message.ToString());
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