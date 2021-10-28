namespace ConsoleApp2.Services
{
    class BrazilTaxService : ITaxService
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
