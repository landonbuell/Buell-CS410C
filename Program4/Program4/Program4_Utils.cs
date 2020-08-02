using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml;

namespace Program4
{
    class InputValidator
    {    
        public static List<int> Call()
        {
            // Call Input Validatior Object           
            List<int> inputs = new List<int>();
            // Accept interg input from user
            for (int i = 1; i < 3; i++)
            {
                while (true)
                {
                    try
                    {
                        Console.Write("Enter Integer {0}:\t", Convert.ToInt32(i));
                        int input = Convert.ToInt32(Console.ReadLine());                       
                        if (input < 0 ^ input > 360)
                            Console.WriteLine("\n\tERROR! - Integer must be [0,360]\n");
                        else if(i == 2 && (input > inputs[0] + 90)^(input < inputs[0] - 90))
                            Console.WriteLine("\n\tERROR! - 2nd Int32 must be within 90 degress of 1st Int32!");
                        else
                        {
                            inputs.Add(input);
                            break;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("\n\tERROR! - Input must be type Int32\n");
                    }
                }
            }
            // Swap s.t. [0] < [1]
            if (inputs[0] > inputs[1])
                inputs.Reverse();
            return inputs;
        }
    }

    class TrigFunctions
    {
        // Init variables
        public int int1, int2;
        public List<int> angles;

        public TrigFunctions(List<int> inputs)
        {
            // Constructor Method
            this.int1 = inputs[0];
            this.int2 = inputs[1];
            this.angles = this.Arange(int1, int2, 5);
        }

        public List<int> Arange (int A, int B, int C)
        {
            // Make List from 'A' to 'B' w/ step size 'C'
            List<int> output = new List<int>();
            for (int i = A; i < B; i += C)           
                output.Add(i);
            return output;
        }
    }

    class Printing
    {
        public static void RepeatString (string str , int n = 128)
        {
            string val = string.Concat(Enumerable.Repeat(str, n));
            Console.WriteLine(val);
        }

        public static void DataRow(string index, List<int> data)
        {
            // Print Out a Row of Data
            Console.Write(index);
        }

    }
}
