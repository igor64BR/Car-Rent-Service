using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Entities
{
    class CarRental
    {
        public DateTime Start { get; set; }
        public DateTime Finish{ get; set; }
        public Vehincle Vehincle { get; set; }
        public Invoice Invoice { get; set; }

        public CarRental() { }
        public CarRental(DateTime start, DateTime finish, Vehincle vehincle)
        {
            Start = start;
            Finish = finish;
            Vehincle = vehincle;
            Invoice = null;
        }
    }
}
