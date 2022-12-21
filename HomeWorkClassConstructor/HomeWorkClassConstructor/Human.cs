using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkClassConstructor
{
    internal class Human
    {

        public Human(string fullname,int age)
        {
            

            //Console.WriteLine("Full Name'i daxil et:");
            //fullname= Console.ReadLine();
            FullName = fullname;

            //Console.WriteLine("Yashi daxil et");
            //var input= Console.ReadLine();  
            //age=Convert.ToInt32(input);
            Age = age;
        }



        public string FullName;
        public int Age;
    }
}
