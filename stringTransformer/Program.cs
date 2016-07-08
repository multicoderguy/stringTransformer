using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        // If user does pass in proper amount of args, show them usage
        if (args.Length != 2)
        {
            Console.WriteLine("usage: stringTransformer string1 string2");
            return;
        }
        try
        {
            // Create a string of commandline arguments
            string startString = String.Concat(args);
            // Generate an array of characters, use linq to enumerate over the characters of the string
            // and filter the results to ony Letters.
            char[] arr = startString.Where(c => (char.IsLetter(c))).ToArray();
            // Write the results
            Console.WriteLine("results: " + (new string(arr)));
        }
        catch (Exception ex)
        {
            Console.Write("An error occurred during the execution of this application");
            return;
        }
    }
}
