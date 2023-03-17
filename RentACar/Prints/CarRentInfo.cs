using RentACar.Classes;
using RentACar.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Prints
{
    public class CarRentInfo : ICarRentInfo
    {

        public void printInfo(Car car)
        {
            Console.WriteLine(
                              $"Manufacturer: {car.Make} \n" +
                              $"Model: {car.Model}\n" +
                              $"Year of production: {car.Year}\n" +
                              $"Offer: {car.Offer}\n" +
                              $"Price of car: {car.Price}$\n" +
                              $"Rental price: {car.CalculateRent()}$\n\n" +
                              $"===========================\n");
        }
    }
}
