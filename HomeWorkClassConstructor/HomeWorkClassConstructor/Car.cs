using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkClassConstructor
{
    internal class Car:Vehicle
    {

        public Car(string brand, string model,int fuelcapasity,int currentfuel):base(brand,model)
        {
            FuelCapasity = fuelcapasity;
            CurrentFuel = currentfuel;
        }
        public int FuelCapasity;
        public int CurrentFuel;


        public  void  AddFuel (int addinF)
        {
            if (CurrentFuel + addinF <= FuelCapasity)

            {
                CurrentFuel += addinF;
                Console.WriteLine(CurrentFuel);

            }
            else
            {
                Console.WriteLine("Error");
            }
            
            
            

        }
    }
}
