using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Classes
{
    public class PremiumCar : Car 
    {
        public PremiumCar(string make, string model, string year, decimal price) : base(make, model, year, price)
        {
            Offer = 'P';
        }


    }
}
