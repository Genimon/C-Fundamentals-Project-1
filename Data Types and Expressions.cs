using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    public class Data_Types_and_Expressions
    {
        public static string numberValidator()
        {
            // Exercise 1a.

            //Console.WriteLine ("Enter a number between 1 to 10.");

            var number = Convert.ToInt32 (Console.ReadLine ());

            // var number = 100;

            if ( number >= 1 && number < 11 )
                Console.WriteLine ("The number {0} is a valid number", number);

            else
                Console.WriteLine ($"The number {number} is not a valid number");

            return Console.ReadLine ();
        }

        public static string maximumNumber()
        {
            // Exercise 1b

            //Console.WriteLine ("Enter two numbers ");

            var a = Convert.ToInt32 (Console.ReadLine ());
            var b = Convert.ToInt32 (Console.ReadLine ());

            Console.WriteLine (@"The numbers inputted are:
            First number = {0}
            Second number = {1}", a, b);

            if ( a > b )
                Console.WriteLine ("The number {0} is the maximum of the two numbers entered", a);

            else
                Console.WriteLine ("The number {0} is the maximum of the two numbers entered", b);

            return Console.ReadLine ();
        }

        public static string imageProperties()
        {
            // Exercise 1c

            //Console.WriteLine ("Enter the width and height of the image respectively in millimeter");

            var width = Convert.ToInt32 (Console.ReadLine ());
            var height = Convert.ToInt32 (Console.ReadLine ());

            Console.WriteLine (@"The dimension of the image is:
            Width of image = {0} mm
            Height of image = {1} mm", width, height);

            if ( width > height )
                Console.WriteLine ("The image with the dimension {0} x {1} mm is a landscape image", width, height);

            else
                Console.WriteLine ("The image with the dimension {0} x {1} mm is a portrait image", width, height);

            return Console.ReadLine ();
        }

        public static string speedLimitCamera()
        {
            // Exercise 1d

            //Console.WriteLine ("Enter the speed limit and speed of your car in km/hr respectively");

            var speedLimit = Convert.ToInt32 (Console.ReadLine ());
            var carSpeed = Convert.ToInt32 (Console.ReadLine ());

            int demeritPoints = 0;

            if ( carSpeed < speedLimit )
            {
                Console.WriteLine ("The speed {0}km/hr is within the speed limit range", carSpeed);
            }

            else
            {
                var speedDiff = carSpeed - speedLimit;

                for ( int counter = 5; counter <= speedDiff; counter += 1 )
                {
                    if ( counter % 5 == 0 )
                    {
                        demeritPoints++;
                    }
                }
            }

            Console.Write ("Demerit Points :");
            Console.WriteLine (demeritPoints);

            if ( demeritPoints >= 12 )
            {
                Console.WriteLine ("Your Demerit Points is {0}, hence, your license is suspended", demeritPoints);
            }
            else
            {
                Console.WriteLine ("You are not suspended");
            }
            return Console.ReadLine();

            //Console.WriteLine("Enter a series of numbers separated by comma");

            //var nums = new List<int>();
        }


    }

    

}
