using RentACar.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Interfaces
{
    internal interface IRentRecepit
    {
        public void printReceipt(Car car);
    }
}
