using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions_and_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to learning in functions and methods");
            /*
             Introduction : A method is a code block that a series of statements.
                        --> Aprogram causes the statements to be executed by calling the method and specifying any 
                        required method argument.
                        --> In C# every executed instruction is performed in the context of a method.
                        --> The main method is the entry point for every c# application and it is called by the 
                        Common Language Runtime (CLR) when the program is started.

            Syntax : <Access specifier> <return type> <method name> (Parameter list)
                        {
                            Mehtod Body
                        }
                        --> Access specifier : It determines the visibility of the variable or a method from the 
                        another class.
                        --> return type : A method may return a value. The return type is the data type of the value 
                        the method returns. If the method not returning any values, then the return type is void
                        --> method name : Method name is a unique identifier and it is case sensitive. It cannot be same as any 
                        other identifier declared in the class.
                        --> Parameter list : Enclosed between parenthesis, the parameter is used to pass and receive
                        data from a method. The parameter list refer to the type, order and number of the parameters of a 
                        method. Parameters are optional i.e. a method may contain no parameter.
                        --> Method body : This contains the set of instructions needed to complete the required activity.

             */
            Console.ReadKey();
        }
    }
}
