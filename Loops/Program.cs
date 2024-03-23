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



            Console.Read();
        }
    }
}
