using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq.Expressions;
using System.Text;

namespace Program5
{
    class ProgramInitializer
    {
        public void ProgramDescription()
        {
            // Display Program Functionaility to User
        }

        public List<int> UserInput()
        {
            // Accept User Input From Command line
            int inputValue;
            List<int> tempValues = new List<int>();

            while (true)
            {        
                try
                {
                    Console.Write("Please Enter a Temperature value in F: ");
                    inputValue = Convert.ToInt32(Console.ReadLine());

                    if (inputValue < -20 ^ inputValue > 50)
                        Console.WriteLine("\n\tERROR! - Input mut be [-20,50]");
                    else
                        tempValues.Add(inputValue);
                    if (tempValues.Count == 2)
                        break;
                }
                catch
                {
                    Console.WriteLine("\n\tERROR! - Input must be of type: int32");
                }
                
            }
            if (tempValues[0] > tempValues[1])
                tempValues.Reverse();
            return tempValues;
        }
        
        public List<double> Arange(int start, int stop, int step)
        {
            // Arange list of doubles 
            List<double> output = new List<double>();
            for (int i = start; i < stop; i+= step)
            {
                double j = Convert.ToDouble(i);
                output.Add(j);
            }
            return output;
        }
    }

    class ConvertUnits
    {
        // Convert Units for F to C or C to F
        public static List<double> FarToCel (List<double> _farList)
        {
            // Convert list of Fahrenheit to Celcius
            List<double> _celList = new List<double>();
            for (int i = 0; i < _farList.Count; i++)
            {
                double _cel = _farList[i] - 32 * (5 / 9);
                _celList.Add(_cel);
            }
            return _celList;
        }

        public static List<double> CelToFar(List<double> _celList)
        {
            // Convert list of Celcius to Farhenheit
            List<double> _farList = new List<double>();
            for (int i = 0; i < _celList.Count; i++)
            {
                double _far = _celList[i] + 32 * (9 / 5);
                _farList.Add(_far);
            }
            return _farList;
        }
    }

    public class TemperatureIndex
    {
        private List<double> tempCelList;
        private List<double> tempFarList;

        public TemperatureIndex (List<double> _tempC, List<double> _tempF)
        {
            // Constructor for Temperature Object
            this.tempCelList = _tempC;
            this.tempFarList = _tempF;          
        }

        private double ComputeWindChill()
        {
            // Compute Wind Chill given Temerature

            return 0.0;
        }

        private double ComputeHeatIndex()
        {
            // Compute Head Index given Temperature
            List<double> coeffs = new List<double>
            {
                -42.379, 2.04901523, 10.14333127, -0.22475541,
                -6.83783e-3, -5.481717e-2, 1.22874e-3, 8.5282e-4,
                -1.99e-6
            };
            List<double> vals = new List<double>
            {

            };
            return 0.0;
        }
    }



}
