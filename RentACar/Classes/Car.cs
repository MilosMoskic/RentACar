using RentACar.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Classes
{
    public class Car
    {
        public string Make;
        public string Model;
        public string Year;
        public char Offer;
        public decimal Price;
        public decimal RentalPrice;


        public decimal CalculateRent()
        {
            RentalCalculation calculation = new RentalCalculation(this);
            return calculation.RentCalculation;
        }

    }
}
