﻿using RentACar.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Interfaces
{
    internal interface IReceiptInfo
    {
        public void printReceipt(ICar car);
    }
}
