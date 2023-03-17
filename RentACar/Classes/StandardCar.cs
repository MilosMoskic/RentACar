using RentACar.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Classes
{
    public class StandardCar : Car
    {
        public StandardCar(string make, string model, string year, decimal price) : base(make, model, year, price)
        {
            Offer = 'S';
        }

    }
}
