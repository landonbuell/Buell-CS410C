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
                Console.Write("Please Input and integer between 1 and 1000:\t");
                try
                {
                    int input = Convert.ToInt32(Console.ReadLine());
                    if (UserInput.ValidInput(input) == true)
                    {
                        // Create Math Object and Run Tests
                        MathSequences Maths = new MathSequences(input);

                        Maths.Fibbonacci_Numbers();
                        Maths.Prime_Numbers();
                        Maths.Collatz_Numbers();
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
