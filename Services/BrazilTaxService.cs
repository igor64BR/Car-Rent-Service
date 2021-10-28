using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Services
{
    class BrazilTaxService
    {
        public double Tax(double amount)
        {
            if (amount <= 100)
                return amount * .2;
            else
                return amount * .15;
        }
    }
}
