using ConsoleApp2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Services
{
    class RentalService
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }

        private ITaxService _taxService;


        public RentalService(double pricePerHour, double pricePerDay, ITaxService taxService)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _taxService = taxService;
        }

        public void ProcessInvoice(CarRental carRental)
        {
            var duration = carRental.Finish.Subtract(carRental.Start);

            double basicPayment = 0.0;
            if (duration.Hours <= 12.0)
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);
            else
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);

            var tax = _taxService.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, tax);
        }
    }
}
