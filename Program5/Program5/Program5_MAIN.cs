using System;
using System.Collections.Generic;

namespace Program5
{
    class Program5_MAIN
    {
        static void Main()
        {
            var Initializer = new ProgramInitializer();
            Initializer.ProgramDescription();
            List<int> userInput = Initializer.UserInput();
            List<double> CelList = Initializer.Arange(userInput[0], userInput[1], 5);
            List<double> FarList = ConvertUnits.CelToFar(CelList);

            var Indexes = new TemperatureIndex(CelList, FarList);


        }
    }
}
