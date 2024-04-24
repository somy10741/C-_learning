using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Somesh ! Welcome to OOPs Lecture");
            // Class :- A class is blue print of an object.
            //          It has actions/abilities so called member functions or methods
            //          and it has properties so called member variables
            //          Inheritance possible
            Car audi = new Car();
            audi.Drive();
            Console.WriteLine("Press 1 to stop the car!");
            string userInput = Console.ReadLine();
            if(userInput == "1")
            {
                audi.Stop();
            }
            else
            {
                Console.WriteLine("Car drives indefinitely");
            }
            Console.ReadKey();
        }
    }
}
