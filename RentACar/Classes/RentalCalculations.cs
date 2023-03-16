using RentACar.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Classes
{
    internal class RentalCalculation : IRentalCalculations
    {

        public decimal RentCalculation;
        public RentalCalculation(Car car)
        {
            RentCalculation = RentCalculations(car);
        }
        public decimal RentCalculations(Car car) 
        {
            if (car.Offer == 'S')
            {
                RegularRentCalculations(car);
            }else if(car.Offer == 'P')
            {
                PremiumRentCalculations(car);
            }
            return RentCalculation;
        }

        public decimal RegularRentCalculations(Car car)
        {
            RentCalculation = 15 * car.Price / 100 + car.Price;
            return RentCalculation;
        }

        public decimal PremiumRentCalculations(Car car)
        {
            RentCalculation = 20 * car.Price / 100 + car.Price;
            return RentCalculation;
        }
    }
}
