/*
 * Landon Buell
 * CS 410C
 * Program 1
 * 17 June 2020
 */


using System;

namespace Program1
{

    class Program1_MAIN
    {
        static void Main()
        {
            // Accept user input for 1st point
            Console.WriteLine("Enter x-axis, then y-axis component for point 1:");
            double [] point1 = new double[2];
            for (int i = 0 ; i < 2 ; i++)
            {
                point1[i] = Convert.ToSingle(Console.ReadLine());
            }
            // Accept user input for 2nd point
            Console.WriteLine("Enter x-axis, then y-axis component for point 2:");
            double [] point2 = new double[2];
            for (int i = 0; i < 2; i++)
            {
                point2[i] = Convert.ToSingle(Console.ReadLine());
            }


            // Create instance & Run Computations for Table 1
            var Point_System = new Point_Pair(point1,point2);
            double dr_mtr = Point_System.Distance();
            double ds_rad = Point_System.Bearing_Angle();
            double da_rad = Point_System.Sweep_Angle();


            // Print Tables
            var Table = new OutputTable(point1, point2);
            Table.Title();
            Table.Hline();
            
            

              
        }
    }
}
