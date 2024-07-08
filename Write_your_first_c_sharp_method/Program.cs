using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Write_your_first_c_sharp_method
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5 };

            void PrintArray()
            {
                foreach (int x in a)
                {
                    Console.Write($"{x} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Contents of Array:");
            PrintArray();
            Console.ReadKey();

            
        }
    }
}
