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
using Microsoft.UI.Xaml.Media.Animation;

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
            
        }

        private void nvMain_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            NavigationViewItem item = args.SelectedItem as NavigationViewItem;

            if (item.Tag != null)
            {
                switch (item.Tag.ToString())
                {
                    case "PageSum":
                        ContentFrame.Navigate(typeof(ADD_NN_N_Page));
                        nvMain.Header = "Сложение";
                        break;
                    case "PageSub":
                        ContentFrame.Navigate(typeof(SUB_NN_N_Page));
                        nvMain.Header = "Вычитание";
                        break;
                    case "PageCheckZero":
                        ContentFrame.Navigate(typeof(N2_NZER_N_B_Page));
                        nvMain.Header = "Проверка на ноль";
                        break;
                    case "PagePoz":
                        ContentFrame.Navigate(typeof(Z2_POZ_Z_D_Page));
                        nvMain.Header = "'Положительность' числа";
                        break;
                    case "PageMultiply":
                        ContentFrame.Navigate(typeof(Z8_MUL_ZZ_Z_Page));
                        nvMain.Header = "Умножение";
                        break;
                }
            }
            
        }


        
    }
}