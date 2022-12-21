using Microsoft.VisualBasic.FileIO;
using System;

namespace HomeWorkClassConstructor
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Task 1
            // Car car1 = new Car("BMW", "X7", 80, 100);

            // car1.AddFuel(15);



            //Task 2

            Console.WriteLine("Sayi daxil et: ");
            var input = Console.ReadLine(); 
            int count=Convert.ToInt32(input);

            Employee[] workers = new Employee[count];
            for (int i = 0; i < workers.Length; i++)
            {
                Console.WriteLine("Fullname daxil et:");
                var fullname = Console.ReadLine();

                Console.WriteLine("Age i daxil et:");
                int age= GetNum(Console.ReadLine());

                Console.WriteLine("Salary daxil et");
                int salary= GetNum(Console.ReadLine());

                Console.WriteLine("Positionu daxil et:");
                var position=Console.ReadLine();

                workers[i]=new Employee(fullname, age, salary,position);

               
            }

        }


      static int GetNum(string num) 
        {
            return Convert.ToInt32(num);
        }
        
    }
}
