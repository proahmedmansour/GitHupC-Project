using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challange1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            /* Define a var that can accept the 'A' value and print that number value in console screen */
            char varA = 'A';
            int charNumberAValue = varA;
            Console.WriteLine("{0} = {1}" , varA ,charNumberAValue);

            /* Define a var that can accept the 'a' value and print that number value in console screen */
            char vara = 'a';
            int charNumberaValue = vara;
            Console.WriteLine("{0} = {1}", vara, charNumberaValue);

            /*Define a sring var and assigned that value "This is my character A value"*/
            string stringVarA = "This is my character A value";
            Console.WriteLine("{0}", stringVarA);

            /*Define a sring var and assigned that value "This is my character a value"*/
            string stringVara = "This is my character a value";
            Console.WriteLine("{0}", stringVara);

            /* print the variables in the form "This is my character A varaible # and This is my character a varaible # " */
            Console.WriteLine("{0} {1} {2} {3}", stringVarA ,charNumberAValue ,stringVara ,charNumberaValue);
              
            Console.ReadKey();
        }
    }
}
