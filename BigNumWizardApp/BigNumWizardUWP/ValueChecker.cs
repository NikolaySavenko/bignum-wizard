using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Windows.UI.Popups;

namespace BigNumWizardUWP
{
    public class ValueChecker
    {
        private static string allowedCharForNumber { get; } = "0123456789-";
        private static string allowedCharForPolynom { get; } = "0123456789- ";
        private static Regex rgxForNumber = new Regex(@"^-?\d*$");
        private static Regex rgxForPolynom = new Regex(@"^(-?\d*\s)*$");

        public static bool CheckNumbersValues(params string[] values)
        {
            bool isAllowed = true;

            foreach (string value in values)
            {
                if (!value.All(allowedCharForNumber.Contains) || !rgxForNumber.IsMatch(value))
                {
                    isAllowed = false;
                }
            }

            return isAllowed;
        }

        public static bool CheckPolynomValues(params string[] values)
        {
            bool isAllowed = true;

            foreach (string value in values)
            {
                if (!value.All(allowedCharForPolynom.Contains) || !rgxForPolynom.IsMatch(value))
                {
                    isAllowed = false;
                }
            }

            return isAllowed;
        }

    }
}
