using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            TransportCredit transportCredit = new TransportCredit();
            MortgageLoan mortgageLoan = new MortgageLoan();

            ApplicationManager applicationManager = new ApplicationManager();
            List<ICreditManager> credits = new List<ICreditManager>() { mortgageLoan, transportCredit };
            applicationManager.CreditPreİnformation(credits);
        }
    }
}
