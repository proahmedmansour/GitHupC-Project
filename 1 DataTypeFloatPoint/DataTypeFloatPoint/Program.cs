using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypeFloatPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            //float Point Types
            float flMaxVar = float.MaxValue;
            float flMinVal = float.MinValue;
            Console.WriteLine("Max Value = {0}\nMin Value = {1}",flMaxVar,flMinVal);

            float flVar = 1F / 3;
            double doVar = 1D / 3;
            decimal deVar = 1M / 3;

            Console.WriteLine("\nFloat Var = {0} \nDouble Var = {1} \nDecimal Var = {2}", flVar, doVar, deVar); 

            /*********************************************************************************************************/
            //Text Types

            int charMin = char.MinValue;
            int charMax = char.MaxValue;
            
            char var = 'G';
            int myVarValue = 'G';
            char myVarValue2 = Convert.ToChar(myVarValue);

            Console.WriteLine("Min Char = {0} , Max Char = {1} , My Charachter = {2} My Char Number(Ascii Code) = {3} Converted Char = {4}",charMin , charMax, var , myVarValue ,myVarValue2);

            string stringVar = "This is string Variable";

            Console.WriteLine("The String Variable Is = {0}", stringVar);

            bool boolVar = true;
            Console.WriteLine("Your Boolean Variable = {0}", boolVar);


            Console.ReadKey();
        }
    }
}
