using RentACar.Classes;
using RentACar.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Prints
{
    internal class ReceiptInfo : IRentRecepit
    {
        public void printReceipt(Car car)
        {
            Console.WriteLine("\n===========================\n" +
                              "\nYour receipt:\n" +
                              $"Manufacturer: {car.Make} \n" +
                              $"Model: {car.Model}\n" +
                              $"Year of production: {car.Year}\n" +
                              $"Offer: {car.Offer}\n" +
                              $"Rental price: {car.CalculateRent()}$\n" +
                              $"Receipt sent on email: something@gmail.com\n\n" +
                              $"Have a nice ride!");
        }
    }
}
