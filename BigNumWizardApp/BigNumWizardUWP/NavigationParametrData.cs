using BigNumWizardShared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigNumWizardUWP
{
    public class NavigationParametrData
    {
        public delegate Polynomial TargetFunctionDelegate(string param1, string param2);

        public string NumberBoxHeader { get; set; }
        public TargetFunctionDelegate Function { get; set; }

        public NavigationParametrData(TargetFunctionDelegate func, string header)
        {
            NumberBoxHeader = header;
            Function = func;
        }
    }
}
