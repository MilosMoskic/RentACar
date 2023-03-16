using RentACar.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Prints
{
    internal class ReceiptOnEmail : IReceiptOnEmail
    {
        public ReceiptOnEmail()
        {

        }

        public void Receipt()
        {
            Console.WriteLine("Do you want to get a email receipt?");
        }
    }
}
