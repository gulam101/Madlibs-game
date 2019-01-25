using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring veriables
            string color, pluralNoun, celebrity;
            string buildNumber = "1.0.0";
            string author = "Gulam Qasim";
            //End

            //Console colour
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            //End

            //Top
            Console.WriteLine("{0}    {1}", author, buildNumber);
            //End

            //Resets colour
            Console.ResetColor();
            //It will reset the colour for everything else below.

            Console.Write("Enter a color: ");
            color = Console.ReadLine();

            Console.Write("Please enter a plural noun: ");
            pluralNoun = Console.ReadLine();

            Console.Write("Lastly please enter a celebrity: ");
            celebrity = Console.ReadLine();

            Console.WriteLine("Roses are {0} ", color);
            Console.WriteLine("{0} are blue", pluralNoun);
            Console.WriteLine("I love " +celebrity+ "");

            Console.ReadLine();
        }
    }
}
