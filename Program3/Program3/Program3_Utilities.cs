/*
 * Landon Buell
 * CS-410C
 * Program3 - Utilities
 * 7 July 2020
 */

using System;
using System.Collections.Generic;

namespace Program3
{

    class UserInput
    {

        public static bool ValidInput(int userinput)
        {
            if (userinput < 1 ^ userinput > 1000)
            {
                Console.WriteLine("\n\tERROR! - Integer out of range, Please try again\n");
                return false;
            }
            else if (userinput == 1000)
            {
                Console.WriteLine("\n\tTerminating Program...");
                Environment.Exit(0);
                return false;
            }
            else
            {
                return true;
            }
        }
    }

    class MathSequences
    {
        public int value;
        public List<int> Fibbonacci;
        public List<int> Primes;
        public List<int> Collatz;

        public MathSequences(int inputvalue)
        {
            // Class Constructor
            value = inputvalue;
            Fibbonacci = new List<int>();
            Primes = new List<int>();
            Collatz = new List<int>();

        }

        public void Fibbonacci_Numbers ()
        {
            // Compute Fibbonacci Sequence up to 'Value'
            int a = 0, b = 1, c = a+b;
            Fibbonacci.Add(a);
            Fibbonacci.Add(b);
            while (c <= value) 
            {
                c = a + b;
                Fibbonacci.Add(c);
                a = b;
                b = c;
            }
            Fibbonacci.RemoveAt(Fibbonacci.Count - 1);
            PrintValues("Fibbonacci Sequnece",Fibbonacci);
        }

        public void Prime_Numbers()
        {
            // Find Primes up to 'value'
            


            PrintValues("Prime Factors", Primes);
        }
        
        public void Collatz_Numbers()
        {
            // Compute Collatz Conjecture starting at 'Value'
            int n = value;
            Collatz.Add(n);
            while (true)
            {
                if (n == 1)
                    break;
                if (n % 2 == 0)
                    n /= 2;
                else
                    n = 3 * n + 1;
                Collatz.Add(n);
                //Console.WriteLine(n);
            }
            PrintValues("Collatz Conjecture", Collatz);
        }

        public void PrintValues (string text,List<int> vals)
        {
            Console.WriteLine("{0} for {1}",text,value);
            foreach (int i in vals)
            {
                Console.Write(i);
                Console.Write(" -> ");
            }
            Console.WriteLine("\nContaining {0} elements\n", vals.Count);
        }

    }
}
