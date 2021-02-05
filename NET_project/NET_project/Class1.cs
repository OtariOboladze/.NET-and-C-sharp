using System;
using System.Globalization;

class camelCaseCadena
{

    static void Main()
    {

        // Define the string by input.
        string myString = Console.ReadLine();

        // Create a TextInfo based on the "en-US" culture.
        TextInfo myTI = new CultureInfo("en-US", false).TextInfo;

        // Change a string to titlecase.
        Console.WriteLine("\"{0}\" : {1}", myString, myTI.ToTitleCase(myString));
    }
}

