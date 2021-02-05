/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_app
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}*/



using System;
using System.Globalization;

class camelCaseCadena
{

    static void Main()
    {
        while (true){
            // Define the string by input.
            string myString = Console.ReadLine();

            // Create a TextInfo based on the "en-US" culture.
            TextInfo myTI = new CultureInfo("en-US", false).TextInfo;

            // Change a string to titlecase.
            Console.WriteLine("\"{0}\" : {1}", myString, myTI.ToTitleCase(myString));
        }
    }
}
