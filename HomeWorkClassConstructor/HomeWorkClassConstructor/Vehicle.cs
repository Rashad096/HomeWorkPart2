using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkClassConstructor
{
    internal class Vehicle
    {

        public Vehicle(string brand)
        {
            Brand= brand;
        }

        public Vehicle(string brand, string model) : this(brand)
        {
            Model= model;
        }


        public string Brand;
        public string Model;
        public int Millage=2300;
        


       




       
    }
}
