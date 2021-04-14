using BigNumWizardApp;
using BigNumWizardShared;
using Windows.Foundation;
using Windows.UI.Xaml.Controls;

namespace BigNumWizardUWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        public static MainPage Current;

        public MainPage()
        {
            this.InitializeComponent();
            Current = this;
        }


        private void OnNavigationViewItemInvoked(Microsoft.UI.Xaml.Controls.NavigationView sender, Microsoft.UI.Xaml.Controls.NavigationViewItemInvokedEventArgs args)
        {

            if (args.InvokedItemContainer.IsSelected)
            {
                // Clicked on an item that is already selected,
                // Avoid navigating to the same page again causing movement.
                return;
            }
            else
            {
                var invokedItem = args.InvokedItemContainer;

                if (invokedItem.Tag != null)
                {
                    switch (invokedItem.Tag.ToString())
                    {
                        case "PageSum":
                            TwoNumbersPage.TargetFunctionDelegate actionSum = (string param1, string param2) =>
                            {
                                return (new BigNum(param1) + new BigNum(param2)).ToString();
                            };
                            ContentFrame.Navigate(typeof(TwoNumbersPage), actionSum);
                            nvMain.Header = "Сложение";
                            break;
                        case "PageSub":
                            TwoNumbersPage.TargetFunctionDelegate actionSub = (string param1, string param2) =>
                            {
                                return (new BigNum(param1) - new BigNum(param2)).ToString();
                            };
                            ContentFrame.Navigate(typeof(TwoNumbersPage), actionSub);
                            nvMain.Header = "Вычитание";
                            break;
                        case "PageMultiply":
                            TwoNumbersPage.TargetFunctionDelegate actionMultiply = (string param1, string param2) =>
                            {
                                return (new BigNum(param1) * new BigNum(param2)).ToString();
                            };
                            ContentFrame.Navigate(typeof(TwoNumbersPage), actionMultiply);
                            nvMain.Header = "Умножение";
                            break;
                        case "PageDivide":
                            TwoNumbersPage.TargetFunctionDelegate actionDivide = (string param1, string param2) =>
                            {
                                var remainer = new BigNum();
                                return Z9.DIV_ZZ_Z(new BigNum(param1), new BigNum(param2), out remainer).ToString();
                            };
                            ContentFrame.Navigate(typeof(TwoNumbersPage), actionDivide);
                            nvMain.Header = "Деление";
                            break;
                        case "PageComparison":
                            TwoNumbersPage.TargetFunctionDelegate actionComparison = (string param1, string param2) =>
                            {
                                return Natural1_5.COM_NN_D(new BigNum(param1), new BigNum(param2)).ToString();
                            };
                            ContentFrame.Navigate(typeof(TwoNumbersPage), actionComparison);
                            nvMain.Header = "Сравнение";
                            break;
                        case "PageN9":
                            ThreeNumbersPage.TargetFunctionDelegate actionN9 = (string param1, string param2, string param3) =>
                            {
                                byte value = param3 != "" ? byte.Parse(param3) : (byte)0;
                                return N9.SUB_NDN_N(new BigNum(param1), new BigNum(param2), value).ToString();
                            };
                            ContentFrame.Navigate(typeof(ThreeNumbersPage), actionN9);
                            nvMain.Header = "Подмодуль N9";
                            break;
                        case "PageN11":
                            ThreeNumbersPage.TargetFunctionDelegate actionN11 = (string param1, string param2, string param3) =>
                            {
                                var value = new BigNum(param3);
                                return N11.DIV_NN_N(new BigNum(param1), new BigNum(param2), out value).ToString();
                            };
                            ContentFrame.Navigate(typeof(ThreeNumbersPage), actionN11);
                            nvMain.Header = "Подмодуль N11";
                            break;
                        case "PageCheckZero":
                            OneNumberPage.TargetFunctionDelegate actionCheckZero = (string param1) =>
                            {
                                return N2_6.NZER_N_B(new BigNum(param1));
                            };
                            ContentFrame.Navigate(typeof(OneNumberPage), actionCheckZero);
                            nvMain.Header = "Проверка на ноль";
                            break;

                    }
                }
            }
        }

    }
}
