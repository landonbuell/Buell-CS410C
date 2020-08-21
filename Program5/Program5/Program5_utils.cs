using System;
using System.Collections.Generic;
using System.Text;

namespace Program5
{
    class ProgramInitializer
    {
        public void ProgramDescription()
        {
            // Display Program Functionaility to User
        }

        public int UserInput()
        {
            // Accept User Input From Command line
            int inputValue;
            while (true)
            {        
                try
                {
                    Console.Write("Please Enter a Temperature value in F: ");
                    inputValue = Convert.ToInt32(Console.ReadLine());

                    if (inputValue < -20 ^ inputValue > 50)
                        Console.WriteLine("\n\tERROR! - Input mut be [-20,50]");
                    else
                        break;
                }
                catch
                {
                    Console.WriteLine("\n\tERROR! - Input must be of type: int32");
                }
                
            }
            return inputValue;
        }     
    }

    class TemperatureIndex
    {
        public int tempF;

        private TemperatureIndex (int _temp)
        {
            // Constructor for Temperature Object
            this.tempF = _temp;
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
