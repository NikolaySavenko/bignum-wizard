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
                        TwoNumbersPage.TargetFunctionDelegate actionSum = (string param1, string param2) =>
                        {
                            return (string)(new BigNum(param1) + new BigNum(param2));
                        };
                        ContentFrame.Navigate(typeof(TwoNumbersPage), actionSum);
                        nvMain.Header = "Сложение";
                        break;
                    case "PageSub":
                        TwoNumbersPage.TargetFunctionDelegate actionSub = (string param1, string param2) =>
                        {
                            return (string)(new BigNum(param1) - new BigNum(param2));
                        };
                        ContentFrame.Navigate(typeof(TwoNumbersPage), actionSub);
                        nvMain.Header = "Вычитание";
                        break;
                    case "PageMultiply":
                        TwoNumbersPage.TargetFunctionDelegate actionMultiply = (string param1, string param2) =>
                        {
                            return (string)(new BigNum(param1) * new BigNum(param2));
                        };
                        ContentFrame.Navigate(typeof(TwoNumbersPage), actionMultiply);
                        nvMain.Header = "Умножение";
                        break;
                    case "PageDivide":
                        TwoNumbersPage.Value2 = "1"; // default value
                        TwoNumbersPage.TargetFunctionDelegate actionDivide = (string param1, string param2) =>
                        {
                            return (string)(new BigNum(param1) / new BigNum(param2));
                        };
                        ContentFrame.Navigate(typeof(TwoNumbersPage), actionDivide);
                        nvMain.Header = "Деление";
                        break;
                }
            }
            
        }


        
    }
}