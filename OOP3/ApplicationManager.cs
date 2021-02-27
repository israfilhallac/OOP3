using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplicationManager
    {
        public void Application (ICreditManager creditManager)
        {
            creditManager.Calculation();
        }
        public void CreditPreİnformation(List<ICreditManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Calculation();
            }
        }
    }
}
