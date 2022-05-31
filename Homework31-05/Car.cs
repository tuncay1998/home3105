using System;
using System.Collections.Generic;
using System.Text;

namespace Homework31_05
{
    internal class Car : Vehicle
    {
        public Car(string brand, string model, int mileage, int FuelCapacity) : base(brand, model, mileage)
        {
            this.FuelCapacity = FuelCapacity;
            
        }


        public int FuelCapacity;

       public void AddFuel (int FuelCapacity)

        {

            for (int i = 0; i < FuelCapacity; i++)
            {
                if (i <= FuelCapacity)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine("Yanacaq ceninde kifayet qeder yer yoxdur");
                }
            }







        }

    }
}
