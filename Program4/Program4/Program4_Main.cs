using System;
using System.Collections.Generic;

namespace Program4
{
    class Program4_Main
    {
        static void Main()
        {
            // Accept & Test User Input
            List<int> InputList = InputValidator.Call();

            // Execution
            TrigFunctions Trigonometry = new TrigFunctions(InputList);
            Trigonometry.Call();

            // Print Table
            Printing.PrintTable(Trigonometry);
        }
    }
}
