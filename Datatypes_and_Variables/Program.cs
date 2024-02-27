using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datatypes_and_Variables
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
            //string myName;
            //Console.Write("Please enter your name and then press enter : ");
            //myName = Console.ReadLine();
            //Console.WriteLine($"You entered name is {myName}");
            //Console.WriteLine($"Upper case : {myName.ToUpper()}");
            //Console.WriteLine($"Lower case : {myName.ToLower()}");
            //Console.WriteLine($"Trim : {myName.Trim()}");
            //Console.WriteLine($"Substring : {myName.Substring(3,8)}");


            /*
             * Challenge 2 – String and its methods 2
             --> Let’s create another console application for more practice.
             --> This application asks the user to input a string in the first line like “Enter a string here: ”.
             --> In the Second Line, it should ask for the character to search in the string which you have entered 
                in the first line like “Enter the character to search: ”
             --> On the third line, it should write the index of the first occurrence of the searched character 
                from the string.
             --> Now on concatenation...
             --> It should then ask to enter the first name and once the name is written and the enter button is 
                pressed, it should ask to enter the last name.
             --> It should then show your full name printed in a single line like in my case the output will 
                 be "Denis Panjuta". Output can be different in your case. Try to store the full name in a variable, 
                 before displaying it.
             */
            //Solution.
            // 1st part
            //Console.Write("Enter a string here: ");
            //string myVal = Console.ReadLine();
            //Console.Write("Enter the character to search: ");
            //char myChar = Console.ReadLine()[0];
            //Console.WriteLine($"The index of the first occurrence of the searched character from the string is : {myVal.IndexOf(myChar)}");

            //// 2nd part
            //Console.Write("Enter the first name: ");
            //string myFirstName = Console.ReadLine();
            //Console.Write("Enter the last name: ");
            //string myLastName = Console.ReadLine();
            //string fullName = string.Concat(myFirstName, " ", myLastName);
            //Console.WriteLine($"The full name you entered is {fullName}.");

            /*
             * Challenge 3 :
             --> Now that you know how to declare and initialize Variables, please go ahead and create a variable 
             for each of the primitive datatypes (you can find the list here). Leave the Object datatype out.
             --> And also please initialize each variable with a working value.
             --> Then create two values of type string. 
             --> The first one should say "I control text"
             --> The second one should be a whole number. Then use the Parse method in order to convert that 
             string to an integer.
             --> Add each an output for each of the variables and write it onto the console. (WriteLine)
             --> Feel free to name your variables as you like, but keep in mind, that my result's variable 
             names will differ to yours.
             Have fun :)
             */
            // Solution
            //byte num1 = 25; // 0 to 255
            //Console.WriteLine(num1);

            //sbyte num2 = 125; //-128 to 127
            //Console.WriteLine(num2);

            //int num3 = 65; // -2,147,483,648 to 2,147,483,647
            //Console.WriteLine(num3);

            //uint num4 = 98;//0 to 4294967295
            //Console.WriteLine(num4);

            //short num5 = 9; //-32,768 to 32,767
            //Console.WriteLine(num5);

            //ushort num6 = 66; //0 to 65535
            //Console.WriteLine(num6);

            //long num7 = 98989; //-9223372036854775808 to 9223372036854775807
            //Console.WriteLine(num7);

            //ulong num8 = 654654654; //0 to 18446744073709551615
            //Console.WriteLine(num8);

            //float num9 = 54564654.5f; //-3.402823e38 to 3.402823e38
            //Console.WriteLine(num9);

            //double num10 = 46454.2454654; //-1.79769313486232e308 to 1.79769313486232e308
            //Console.WriteLine(num10);

            //char val1 = 's'; // Unicode symbols used in text
            //Console.WriteLine(val1);

            //bool val2 = true; //True or false
            //Console.WriteLine(val2);

            //object val3 = "somesh";
            //Console.WriteLine(val3);

            //string val4 = "my name is somesh kumar"; // A sequence of characters
            //Console.WriteLine(val4);

            //decimal val5 = 65656.32M; //±1.0 × 10e−28 to ±7.9 × 10e28
            //Console.WriteLine(val5);

            //string numText = "32";
            //Console.WriteLine(int.Parse(numText));

            //-----------------------------------------------------------------------------------------------------------
            /*------- using the "var" keyword ---------------*/
            /* --> The var keyword allows to create a variable where the variable is typed implicitly based 
            on what you are assigning to the variable.
            On initialisation you mustinitialize it and after that you cannot change the datatype of that
            eg. var myNum = 10; // possible
            var myNum; //not possible and showing error because we need to initialise the variable in var
            */
            Console.WriteLine("Hello world");
            Console.ReadKey();
        }
    }
}
