using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello Somesh !!!! Welecome C# Learning");
            //Console.ReadLine();
            //Console.Beep();
            //Console.WriteLine("I will give one commitment to myself i.e. I will learn basic C#.");
            //Console.Beep();
            //Console.ReadLine();

            ////Variables and datatypes
            ////declaring a variable
            //int num1;

            ////Assign a value to variable
            //num1 = 60;
            //int num2 = 33;
            //int sum = num1 + num2;
            //Console.WriteLine(sum);
            //Console.Read();

            string name = "Somesh Kumar Sahu";
            Console.WriteLine("My name is " + name);

            //Convert the string to all UPPERCASE
            string nameUpper = name.ToUpper();
            Console.WriteLine("My name is " + nameUpper);

            //Convert the string to all lowercase
            string nameLower = name.ToLower();
            Console.WriteLine("My name is " + nameLower);

            Console.Read();

        }
    }
}
