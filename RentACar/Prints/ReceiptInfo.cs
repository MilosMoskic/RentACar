using RentACar.Classes;
using RentACar.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Prints
{
    public class ReceiptInfo : IReceiptInfo
    {
        public void printReceipt(ICar car)
        {
            Console.WriteLine("\n===========================\n" +
                              "\nYour receipt:\n" +
                              $"Manufacturer: {car.Make} \n" +
                              $"Model: {car.Model}\n" +
                              $"Year of production: {car.Year}\n" +
                              $"Offer: {car.Offer}\n" +
                              $"Rental price: {car.CalculateRent()}$\n" +
                              $"Have a nice ride!");
        }
    }
}
