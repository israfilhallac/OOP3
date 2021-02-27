using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class MortgageLoan : ICreditManager
    {
        public void Calculation()
        {
            Console.WriteLine("Konut Kredisi Ödeme Planı Hesaplandı");
        }
    }
}
