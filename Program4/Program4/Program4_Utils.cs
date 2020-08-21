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
        public List<double> anglesDeg;
        public List<double> anglesRad;
        public List<double> sinList;
        public List<double> cosList;
        public List<double> tanList;
        public int negSinVals;
        public int negCosVals;
        public int negTanVals;

        public TrigFunctions(List<int> inputs)
        {
            // Constructor Method
            this.int1 = inputs[0];
            this.int2 = inputs[1];
            this.anglesDeg = Arange(int1, int2, 5);
            this.anglesRad = DegToRad(anglesDeg);
        }

        private List<double> Arange (int A, int B, int C)
        {
            // Make List from 'A' to 'B' w/ step size 'C'
            List<double> output = new List<double>();
            for (double i = A; i < B; i += C)           
                output.Add(i);
            return output;
        }

        private List<double> DegToRad (List<double> deg)
        {
            // Convert Values in Degrees into Radian
            List<double> rad = new List<double>();
            for (int i = 0; i < deg.Count; i++)
                rad.Add(deg[i] * (Math.PI / 180.0));
            return rad;
        }

        public void Call()
        {
            // Apply Trig Function Element-Wise to list
            List<double> _sinList = new List<double>(); 
            List<double> _cosList = new List<double>(); 
            List<double> _tanList = new List<double>();
            int _negSinVals = 0, _negCosVals = 0, _negTanVals = 0;
            for (int i = 0; i < anglesRad.Count;i++)
            {
                double arg = anglesRad[i];
                // Get sin,cos,tan vals, determine if less than 0
                double _sinVal = Math.Round(Math.Sin(arg), 8);
                if (_sinVal < 0) { _negSinVals += 1; }
                double _cosVal = Math.Round(Math.Sin(arg), 8);
                if (_cosVal < 0) { _negCosVals += 1; }
                double _tanVal = Math.Round(Math.Sin(arg), 8);
                if (_tanVal < 0) { _negTanVals += 1; }
                // Add to respective lists
                _sinList.Add(_sinVal);
                _sinList.Add(_cosVal);
                _sinList.Add(_tanVal);
            }
            // Set at attributes
            this.sinList = _sinList;
            this.cosList = _cosList;
            this.tanList = _tanList;
            this.negSinVals = _negSinVals;
            this.negCosVals = _negCosVals;
            this.negTanVals = _negTanVals;
        }
    }

    class Printing
    {
        public static void RepeatString (string str , int n = 128)
        {
            string val = string.Concat(Enumerable.Repeat(str, n));
            Console.WriteLine(val);
        }

        public static void DataRow(string index, List<double> data)
        {
            // Print Out a Row of Data
            Console.Write("{0,-10}",index);
            for (int i = 0; i < data.Count; i++)
                Console.Write("{0,-12}",Convert.ToString(data[i]));
        }

        public static void PrintTable (TrigFunctions trigObj)
        {
            Console.WriteLine("Input 1: {0}, Input 2: {1}", trigObj.int1, trigObj.int2);
            int nDashes = trigObj.anglesDeg.Count * 12;
            RepeatString("-", nDashes);
            DataRow("Angle: ", trigObj.anglesDeg);
            RepeatString("-", nDashes);
            DataRow("Sine:", trigObj.sinList);
            RepeatString("-", nDashes);
            DataRow("Cosine:", trigObj.sinList);
            RepeatString("-", nDashes);
            DataRow("Tangent:", trigObj.sinList);
            RepeatString("-", nDashes);
            Console.WriteLine("Negative Sine Values: {0}",trigObj.negSinVals);
            Console.WriteLine("Negative Cosine Values: {0}",trigObj.negCosVals);
            Console.WriteLine("Negative Tangent Values: {0}",trigObj.negTanVals);
        }
    }
}
