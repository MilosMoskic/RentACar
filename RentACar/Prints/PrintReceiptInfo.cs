using RentACar.Classes;
using RentACar.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Prints
{
    internal class PrintReceiptInfo : IRentRecepit
    {
        public PrintReceiptInfo() { }

        public void printReceipt(Car car)
        {
            Console.WriteLine("\nYour receipt:\n" +
                              $"Car: {car.Model}\n" +
                              $"Receipt sent on email: something@gmail.com\n" +
                              $"Have a nice ride!");
        }
    }
}
