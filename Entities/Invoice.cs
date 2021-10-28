namespace ConsoleApp2.Entities
{
    public class Invoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }
        public double TotalPayment {
            get { return BasicPayment + Tax; }
        }

        public Invoice() { }
        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        public override string ToString()
        {
            return
                "INVOICE: \n"
                + "\tBasic Payment: " + BasicPayment
                + "\n\tTax: " + Tax
                + "\n\tTotal Payment: " + TotalPayment;
        }
    }
}