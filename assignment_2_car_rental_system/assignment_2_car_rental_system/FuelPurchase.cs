﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_2_car_rental_system
{
    class FuelPurchase
    {
        public double Litres { get; set; }
        public double Cost { get; set; }

        /// <summary>
        /// Class Constructor
        /// </summary>
        public FuelPurchase()
        {
            Litres = 0;
            Cost = 0;
        }

        public void purchaseFuel(double amount, double price)
        {            
            Litres += amount;
            Cost += price;            
        }
    }
}
