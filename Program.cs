using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
   
    class Program
    {
        static void Main(string[] args)
        {

            while ( true )
            {
                Console.WriteLine (@"Make your selection of program you want to access.
- Enter V to select Number Validator.
- Enter M to select Maximum Number.
- Enter I to select Image Properties. 
- Enter S to select Speed Limit Camera.");

                var selection = (string)Console.ReadLine ();


                const string validator = "v";
                const string maximum = "m";
                const string image = "i";
                const string speed = "s";



                switch ( selection.ToLower () )
                {

                    case validator:
                        Console.WriteLine ();
                        Console.WriteLine ("You selected Number Validator");
                        Console.WriteLine ("Enter a number between 1 to 10.");
                        Console.WriteLine (Data_Types_and_Expressions.numberValidator ());
                        Console.WriteLine ();
                        continue;

                    case maximum:
                        Console.WriteLine ();
                        Console.WriteLine ("You selected Maximum Number");
                        Console.WriteLine ("Enter two numbers to display the maximum.");
                        Console.WriteLine ();
                        Console.WriteLine (Data_Types_and_Expressions.maximumNumber ());
                        Console.WriteLine ();
                        continue;

                    case image:
                        Console.WriteLine ();
                        Console.WriteLine ("You selected Image Properties");
                        Console.WriteLine ("Enter the width and height of the image respectively in millimeter");
                        Console.WriteLine ();
                        Console.WriteLine (Data_Types_and_Expressions.imageProperties ());
                        Console.WriteLine ();
                        continue;

                    case speed:
                        Console.WriteLine ();
                        Console.WriteLine ("You selected Speed Limit Camera");
                        Console.WriteLine ("Enter the speed limit and speed of your car in km/hr respectively");
                        Console.WriteLine ();
                        Console.WriteLine (Data_Types_and_Expressions.speedLimitCamera ());
                        Console.WriteLine ();
                        continue;

                    default:
                        Console.WriteLine ();
                        Console.WriteLine ("Invalid selection");
                        Console.WriteLine ();
                        break;
                }

                break;

            }

        }
    }
}
