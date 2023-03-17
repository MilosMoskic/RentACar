using RentACar.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Classes
{
    public class Car : ICar
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public char Offer { get; set; }
        public decimal Price { get; set; }
        public decimal RentalPrice { get; set; }

        public Car(string make, string model, string year, decimal price)
        {
            Make = make;
            Model = model;
            Year = year;
            Price = price;
        }
        public decimal CalculateRent()
        {
            RentalCalculation calculation = new RentalCalculation(this);
            return calculation.RentCalculation;
        }

    }
}
