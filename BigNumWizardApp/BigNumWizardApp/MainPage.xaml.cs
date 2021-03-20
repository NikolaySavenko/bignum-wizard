﻿using System;
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
        public MainPage()
        {
            this.InitializeComponent();
            numberBox1.ValueChanged += NumberBox1_ValueChanged;
            numberBox2.ValueChanged += NumberBox2_ValueChanged;
        }

		private void NumberBox1_ValueChanged(NumberBox sender, NumberBoxValueChangedEventArgs args)
		{
            textBlock.Text = "AMAZINHG1";
		}

        private void NumberBox2_ValueChanged(NumberBox sender, NumberBoxValueChangedEventArgs args)
        {
            textBlock.Text = "AMAZINHG2";

        }
    }
}
