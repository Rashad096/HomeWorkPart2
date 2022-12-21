using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkClassConstructor
{
    internal class Employee:Human
    {
        public Employee(string fullname,int age,int salary,string position):base(fullname, age)
        {
            //Console.WriteLine("Geliri daxil et:");
            //var input=Console.ReadLine();
            //salary = Convert.ToInt32(input);
           Salary= salary;

            //Console.WriteLine("Positionu daxil et:");
            //position=Console.ReadLine();
            Position= position; 
        }


        
        public int Salary;
        public string Position;
    }
}
