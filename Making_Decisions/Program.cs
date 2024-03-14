using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Making_Decisions
{
    class Program
    {
        static int LastHighScore = 150;
        static string LastHighScorePlayerName = "Somesh Kumar Sahu";
        static int highScore;
        static string playerName;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Somesh! Lets learn making decisions");
            //if statement
            //int temp = int.Parse(Console.ReadLine());
            //if (temp < 10)
            //{
            //    Console.WriteLine("Wear the coat");
            //}
            //if (temp == 10)
            //{
            //    Console.WriteLine("Its 10 degree outside");
            //}
            //if (temp > 10)
            //{
            //    Console.WriteLine("Dont wear the coat");
            //}


            //Using tryParse method
            //string val = Console.ReadLine();
            //int temp;
            //bool success = int.TryParse(val, out temp);
            //if (success)
            //{
            //    Console.WriteLine("Parsing successful - number is {0}",temp);
            //}
            //else
            //{
            //    Console.WriteLine("Parsing failed");
            //}

            /*------------  NestedIf  -------------*/
            /*
             Challenge - If Statements
                    --> Create a user Login System, where the user can first register and then Login in. The Program 
                    should check if the user has entered the correct username and password, wenn login in (so the 
                    same ones that he used when registering).
                    --> As we haven't covered storing data yet, just create the program in a way, that registering 
                    and logging in, happen in the same execution of it.
                    --> User If statements and User Input and Methods to solve the challenge.
             */
            //Registering the username
            //Console.WriteLine("");
            //Console.WriteLine("");
            //Console.WriteLine("------- Registration form --------");
            //Console.Write("Enter the username to register : ");
            //string UserName = Console.ReadLine();
            //Console.Write("Enter the password to register : ");
            //string Password = Console.ReadLine();
            //Console.Write("Registered Successfully");
            //Console.WriteLine("");
            //Console.WriteLine("");
            ////Signing in
            //Console.WriteLine("------- Sign in --------");
            //Console.Write("Enter the username to login : ");
            //string LoginName = Console.ReadLine();
            //Console.Write("Enter the password to login : ");
            //string LoginPassword = Console.ReadLine();

            //if(UserName.Equals(LoginName) && Password.Equals(LoginPassword))
            //{
            //    Console.WriteLine("Welcome to the Main Page");
            //}
            //else
            //{
            //    Console.WriteLine($"LoginName : {LoginName} and LoginPassword : {LoginPassword} is invalid!!! Please enter correct username and password");
            //}

            /*---------------------------------------*/

            /*
             Challenge - If Statements 2
                --> Create an application with a score, highscore and a highscorePlayer.
                --> Create a method which has two parameters, one for the score and one for the playerName.
                --> When ever that method is called, it should be checked if the score of the player is higher 
                than the highscore, if so, "New highscore is + " score" and in another line "New highscore holder is " 
                + playerName - should be written onto the console, if not "The old highscore of " + highscore + " 
                could not be broken and is still held by " + highscorePlayer.
                --> Consider which variables are required globally and which ones locally.
             */
            //Console.Write("Enter the score : ");
            //highScore = int.Parse(Console.ReadLine());
            //Console.WriteLine("ENter the player name : ");
            //playerName = Console.ReadLine();
            //CheckHighScore(highScore,playerName);


            /*-------------------------------------------------------------------------------------------------*/
            /************** Ternary Operrator   ********************/
            int inputTemperature = 0;
            string temperatureMessage = string.Empty;
            string inputValue = string.Empty;

            //takes input from console
            Console.Write("Enter the current temperature : ");
            inputValue = Console.ReadLine();

            //validate the input as validate integer or not
            bool validInteger = int.TryParse(inputValue, out inputTemperature);

            if (validInteger)
            {
                //if the valid integer then it will check for the conditions using nested ternary operator
                temperatureMessage = inputTemperature <= 15 ? 
                    // True
                    "It is very cold. Please wear the woolen clothes" :

                    //False
                    (inputTemperature > 15 && inputTemperature <= 30) ?

                    // True
                    "It is cold." :

                    // True
                    inputTemperature > 30 ?

                    //False
                    "The weather is hot" : "";
                Console.WriteLine(temperatureMessage);
            }
            else
            {
                Console.WriteLine("Not a valid temperature");
            }
            Console.ReadKey();
        }
        //public static void CheckHighScore(int highScore, string playerName)
        //{
            
        //    if(highScore > LastHighScore)
        //    {
        //        Console.WriteLine($"New highscore is {highScore}");
        //        Console.WriteLine($"New highscore holder is {playerName}");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"The old highscore of {LastHighScore} could not be broken and is still held by {LastHighScorePlayerName}.");
        //    }
        //}
    }
}
