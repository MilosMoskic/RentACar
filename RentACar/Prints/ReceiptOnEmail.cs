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
        public void ReceiptSentToEmail()
        {
            Console.WriteLine("Receipt has been sent to your email.");
        }
    }
}
