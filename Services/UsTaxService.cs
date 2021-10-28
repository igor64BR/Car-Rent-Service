namespace ConsoleApp2.Services
{
    class UsTaxService : ITaxService
    {
        public double Tax(double amount)
        {
            if (amount <= 50)
                return amount * .3;
            else
                return amount * .1;
        }
    }
}
