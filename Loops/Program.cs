using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the learning loops");
            //------------------------- For Loop ---------------------
            //Write a program to identify odd numbers

            //for (int i = 0; i < num; i++)
            //{
            //    if (num % 2 == 0)
            //    {
            //        Console.WriteLine("This is a even number");
            //    }
            //    else
            //    {
            //        Console.WriteLine("This is a odd number");
            //    }
            //}
            //-----------------------------------------------------------------------------
            //Write a program to identify odd numbers
            //for (int i = 1; i <= num; i=i+2)
            //{
            //    Console.WriteLine(i);
            //}

            //-------------------------------- do while loop -----------------------------------------------
            //int counter = 0;
            //int lengthOfText = 0;
            //string wholeText = " ";
            //do
            //{
            //    Console.WriteLine("Please enter the name of a friend");
            //    string nameOfAFriend = Console.ReadLine();
            //    int currentLength = nameOfAFriend.Length;
            //    lengthOfText += currentLength;
            //    wholeText += nameOfAFriend;
            //} while (lengthOfText < 30);
            //Console.WriteLine("Thanks, that was enough " + wholeText);

            //------------------------------- Break and Continue --------------------------------
            /*
             Challenge - Loops 1 - Average
                Imagine you are a developer and get a job in which you need to create a program for a teacher.
                He needs a program written in c# that calculates the average score of his students. So he wants
                to be able to enter each score individually and then get the final average score once he enters -1.
                So the tool should check if the entry is a number and should add that to the sum. Finally once he
                is done entering scores, the program should write onto the console what the average score is.
                The numbers entered should only be between 0 and 20. Make sure the program doesn't crash if the
                teacher enters an incorrect value.
                Test your program thoroughly.
             */
            // Solution
            string input = "0";
            int count = 0;
            int total = 0;
            int currentNumber = 0;

            while (input != "-1")
            {
                Console.WriteLine("Last number was {0}", currentNumber);
                Console.WriteLine("Please enter the next score");
                Console.WriteLine("Current amount of entries {0}", count);
                Console.WriteLine("Please enter -1 once you are ready to calculate the average");

                input = Console.ReadLine();
                if (input.Equals("-1"))
                {
                    Console.WriteLine("--------------------------------------------------");
                    // Calculate the average and let the teacher know
                    double average = (double)total / (double)count;
                    Console.WriteLine("The average score of students is {0}", average);
                }
                if(int.TryParse(input, out currentNumber) && currentNumber > 0 && currentNumber <= 20)
                {
                    total += currentNumber;
                }
                else
                {
                    if (!input.Equals("-1"))
                    {
                        Console.WriteLine("Please enter a value between 1 and 20");
                    }
                    continue;
                }
                count++;
            }


            Console.Read();
        }
    }
}
