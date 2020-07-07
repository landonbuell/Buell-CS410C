/*
 * Landon Buell
 * CS 410C
 * Program2 - MAIN
 * 6 July 2020
 */

using System;

namespace Program2
{
    class Program2_MAIN
    {
        static void Main()
        {
            // Instantiate 'While' Loop & repeat
            while (true)
            {
                Console.WriteLine("Input Year:");
                int year = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\tYear of interest: {0}", year);

                if (year > 9999 ^ year < -9999)
                {
                    // If year out of bounds, terminate loop & program 
                    Console.WriteLine("\tYear Out of Bounds, terminating!");
                    break;
                }
                else
                {
                    // Make Year object
                    var year_obj = new ParseYear(year);
                    string cal_type = year_obj.calendar_type;
                    bool leapyear = year_obj.leap;

                    // Print Results:
                    Console.WriteLine("Year:{0,8}, Calendar Type:{1,12}, Leap Year: {2,8}",
                        year,cal_type,leapyear);

                }
                
            }
        }
    }
}
