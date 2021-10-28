using ConsoleApp2.Entities;
using ConsoleApp2.Services;
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void print(string text)
        {
            Console.Write(text);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental data");
            Console.WriteLine("Car model: ");
            var vehincle = new Vehincle(Console.ReadLine());

            System.Console.WriteLine("Pickup(dd / MM / yyyy hh: mm):");
            var pickupDate = DateTime.Parse(Console.ReadLine());
            
            System.Console.WriteLine("Return(dd / MM / yyyy hh: mm):");
            var returnDate = DateTime.Parse(Console.ReadLine());
            
            System.Console.WriteLine("Enter price per hour:");
            var pphour = double.Parse(Console.ReadLine());
            
            System.Console.WriteLine("Enter price per day:");
            var ppday = double.Parse(Console.ReadLine());

            var rent = new CarRental(pickupDate, returnDate, vehincle);

            var rentalService = new RentalService(pphour, ppday);
            rentalService.ProcessInvoice(rent);

            Console.WriteLine(rent.Invoice.ToString());
        }
    }
}
