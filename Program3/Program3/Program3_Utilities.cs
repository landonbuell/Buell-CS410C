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
    class MathSequences
    {
        public int value;
        public List<int> Fib_nums;

        public MathSequences(int user_input)
        {
            // Class Constructor
            this.value = user_input;
        }

        public List<int> RunFibbonacci()
        {
            int N = 0;
            while (N <= this.value) ;
            int new_num = Fibbonacci(N);
            Fib_nums.Add(new_num);
            return Fib_nums;
        }
        public int Fibbonacci (int N)
        {
            // Compute Fibbonacci Number
            if (N == 0) { return 0; }
            else if (N == 1) { return 1; }
            else { return Fibbonacci(N - 1) + Fibbonacci(N + 1); }
        }

    }
}
