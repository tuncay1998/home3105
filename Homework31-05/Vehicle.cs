using System;
using System.Collections.Generic;
using System.Text;

namespace Homework31_05
{
    internal class Vehicle
    {
        public Vehicle(string brand, string model, int mileage)
        {
            this.Brand = brand;
            this.Model = model;
            this.Mileage = mileage;
        }
        public string Brand;
        public string Model;
        public int Mileage;

        
    }
}
