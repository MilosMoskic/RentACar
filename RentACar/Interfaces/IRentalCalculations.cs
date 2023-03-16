using RentACar.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Interfaces
{
    public interface IRentalCalculations
    {
        public decimal RentCalculations(Car car);
        public decimal RegularRentCalculations(Car car);
        public decimal PremiumRentCalculations(Car car);
    }
}
