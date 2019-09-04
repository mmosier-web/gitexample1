using System;

namespace gitexample1
{
    class Program
    {
        static void Main(string[] args)

        { 
            string firstName = "Mike";
            string lastName = "mosier";
            int age = 27;

            int puttingOnSomeYears = 33;

            int oldAge = age + puttingOnSomeYears;

            Console.WriteLine(firstName + " " + lastName);



            Console.WriteLine("I am " + age + " years old");



            Console.WriteLine("I'm really glad I'm not "+oldAge+"years old");
               
        }
    }
}