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

            //----------------------------------------------------------
            //string name = "Somesh Kumar Sahu";
            //Console.WriteLine("My name is " + name);

            ////Convert the string to all UPPERCASE
            //string nameUpper = name.ToUpper();
            //Console.WriteLine("My name is " + nameUpper);

            ////Convert the string to all lowercase
            //string nameLower = name.ToLower();
            //Console.WriteLine("My name is " + nameLower);

            //----------------------------------------------------------

            //Read and ReadLine Methods
            //Console.Write("Enter a string and press Enter : ");
            //string readInput = Console.ReadLine();
            //Console.WriteLine("You have entered {0}", readInput);

            //Console.Write("Enter a key and press Enter : ");
            //int asciiValue = Console.Read();
            //Console.WriteLine("Ascii value of entered key is {0}", asciiValue);
            //Console.ReadKey();
            //Console.Read();
            //----------------------------------------------------------

            //Implicit and explicit conversions
            //Implicit conversions
            // Convert int to double
            //int num = 36;
            //double numDouble = num;
            //Console.WriteLine("The conversion from int to double is : " + numDouble);


            //Explicit conversions
            // Convert double to int
            //double num2 = 36.9658;
            //Console.WriteLine(num2);
            //int numInt = (int) num2;
            //Console.WriteLine("The conversion from double to is : " + numInt);

            //Type conversion
            //double num2 = 36.9658;
            //string myString = num2.ToString();
            //Console.WriteLine("The conversion from double to string is : " + myString);

            //-----------------------------------------------------------------------------------------------------------

            //Convert the string to number by using parse method
            //string val1 = "32";
            //string val2 = "50";
            //string resultString = val1 + val2;
            //Console.WriteLine(resultString);
            //int num1 = Int32.Parse(val1);
            //int num2 = Int32.Parse(val2);
            //int resultInt = num1 + num2;
            //Console.WriteLine(resultInt);

            /*
             * Assigment-1
                 * Parse the string variables from below into the correct datatypes:
                    public static void Main(string[] args)
                    {   
                       string stringForFloat = "0.85"; // datatype should be float
                       string stringForInt = "12345"; // datatype should be int
                    } 
                    Questions for this assignment
                    Share your solution (paste code):
                        string stringForFloat = "0.85"; // datatype should be float
                        string stringForInt = "12345"; // datatype should be int
                        float val1 = float.Parse(stringForFloat);
                        int val2 = Int32.Parse(stringForInt);
                        Console.WriteLine("String to float : {0} and String to Int : {1}",val1,val2);
             
             */
            //-----------------------------------------------------------------------------------------------------------
            //String manipulation
            //1. String concatination.
            //Declaring variable
            //int age = 32;
            //string name = "Somesh Kumar Sahu";
            //string companyName = "ZF India Pvt. Ltd. Hyderabad";
            //Console.WriteLine("String concatination");
            //Console.WriteLine("My name is " + name + " and My age is " + age + ". Currently I am working in " + companyName);

            ////2. String formatting :- It is used with the help of indexes
            //Console.WriteLine("String formating");
            //Console.WriteLine("My name is {0} and My age is {1}. Currently I am working in {2}",name,age,companyName);

            ////3. String interpolation :- It uses $ at the start which will allow us to write variables like {variableName}
            //Console.WriteLine("String interpolation");
            //Console.WriteLine($"My name is {name} and My age is {age}. Currently I am working in {companyName}");

            ////4. Verbatim strings :- instead of using \\ to write paths we can use verbatim strings to make it easier
            //// if you remove the @ you will get an error because \U, \A and \D are not valid escape characters
            //Console.WriteLine("verbatim strings");
            //Console.WriteLine(@"F:\C# COurse\HelloWorld\Sahu.png");

            //-----------------------------------------------------------------------------------------------------------

            //*********** Various String Methods **************
            //--> SubString(Int32) : It is used to get the substring from the string, starting from the specified index.
            //--> ToLower() : It is used to convert the string to lowercase.
            //--> ToUpper() : It is used to convert the string to uppercase.
            //--> Trim() : It is used to trim all leading and trailing white space from the string.
            //--> IndexOf() : It is used to get the first occurence of the string or character inside the string
            //--> IsNullOrWhiteSpace : It returns true if the string is either null or is blank else it returns false

            //string firstName = "Somesh";
            //string lastName = "Kumar";
            //string fullName = string.Concat(" ", firstName, lastName, " ");
            //Console.WriteLine(fullName);
            //Console.WriteLine(firstName.Substring(2));
            //Console.WriteLine(firstName.ToLower());
            //Console.WriteLine(firstName.ToUpper());
            //Console.WriteLine(fullName.Trim());
            //Console.WriteLine(firstName.IndexOf('m'));
            //Console.WriteLine(String.IsNullOrWhiteSpace(firstName));
            //Console.WriteLine(String.Format($"My name is {fullName}"));

            /*
             Challenge 1 – String and its methods
             --> Now you know the use of various string functions so let’s create a small Console application 
             to practice this.
             --> Declare a string variable and don’t assign any value to it.
             --> Print on the console “Please enter your name and press enter”. You can then enter your name 
             or any other valid string like “tutorials.eu”.
             --> Assign that entered string to the string variable which you have declared initially.
             --> The program should write on the console that string in Uppercase in the first line, 
             then the same string in Lowercase in the second line. In the third line, it writes on the 
             console the string with no trailing or preceding white space like if string entered as “ tutorials.eu ” 
             it should be written on the console as “tutorials.eu”. And in the last line, it should write the 
             Substring of the entered string on the console.
             --> These kinds of features are e.g. used when creating a login screen, where the system 
             will cut out trailing or preceding white space or, doesn’t care about the casing of the 
             entered username.
             */
            // Solution.
            string myName;
            Console.Write("Please enter your name and then press enter : ");
            myName = Console.ReadLine();
            Console.WriteLine($"You entered name is {myName}");
            Console.WriteLine($"Upper case : {myName.ToUpper()}");
            Console.WriteLine($"Lower case : {myName.ToLower()}");
            Console.WriteLine($"Trim : {myName.Trim()}");
            Console.WriteLine($"Substring : {myName.Substring(3,8)}");
            Console.ReadKey();
        }
    }
}
