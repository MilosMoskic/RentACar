using RentACar.Interfaces;
using RentACar.Prints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Classes
{
    public class Factory
    {
        public static Car CreateCar(string name, string model, string year, decimal price)
        {
            return new Car(name, model, year, price);
        }

        public static StandardCar CreateStandardCar(string name, string model, string year, decimal price)
        {
            return new StandardCar(name, model, year, price);
        }
        public static PremiumCar CreatePremiumCar(string name, string model, string year, decimal price)
        {
            return new PremiumCar(name, model, year, price);
        }

        public static ReceiptInfo CreateReceiptInfo()
        {
            return new ReceiptInfo();
        }
        public static CarRentInfo CreateCarRentInfo()
        {
            return new CarRentInfo();
        }
        public static ReceiptOnEmail CreateReceiptOnEmail()
        {
            return new ReceiptOnEmail();
        }
    }
}
