/*
 * Landon Buell
 * CS-410C
 * Program3 - Main
 * 7 July 2020
 */

using System;

namespace Program3
{
    class Program3_MAIN
    {
        static void Main()
        {
            while (true)
            {
                // Accept User Input
                Console.Write("Please Input and integer between 1 and 1000:");
                try
                {
                    int input = Convert.ToInt32(Console.ReadLine());

                    // Test User Input:
                    if (input < 1 ^ input > 1000)
                    {
                        Console.WriteLine("\n\tERROR! - Integer out of range, Please try again\n");
                    }
                    else if (input == 1000)
                    {
                        // Terminate program if input is 1000
                        break;
                    }
                    else
                    {
                        // Create Object and Run tests
                        var sequences = new MathSequences(input);
                    }
                }
                catch
                {
                    // Exception, Probably invalid user type
                    Console.WriteLine("\n\tERROR! - Could not convert to integer, Please try again\n");
                }
                
            }
        }
    }
}
