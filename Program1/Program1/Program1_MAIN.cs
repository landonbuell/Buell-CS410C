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
            double distance_mtrs = Point_System.Distance();
            double bearing_rad = Point_System.Bearing_Angle();
            double sweep_rad = Point_System.Sweep_Angle();

            // Create Conversion Instance
            var Converter = new Conversions();
            double distance_ft = Converter.mtr_to_ft(distance_mtrs);
            double bearing_deg = Converter.rad_to_deg(bearing_rad);
            double sweep_deg = Converter.rad_to_deg(sweep_rad);

            // Initalize Table and Title   
            var Table = new OutputTable(point1, point2);
            Table.Title();

            // First Sub-Table
            string[] row1 = { "Distance (meters)", "Bearing (Rad)", "Sweep (Rad)" };
            double[] body1 = { distance_mtrs, bearing_rad, sweep_rad };
            Table.Subtable(row1, body1);

            // Second Sub-Table
            string[] row2 = { "Distance (meters)", "Bearing (Deg)", "Sweep (Deg)" };
            double[] body2 = { distance_mtrs, bearing_deg, sweep_deg };
            Table.Subtable(row2, body2);

            // Third Sub-Table
            string[] row3 = { "Distance (ft)", "Bearing (rad)", "Sweep (rad)" };
            double[] body3 = { distance_ft, bearing_rad, sweep_rad };
            Table.Subtable(row3, body3);







        }
    }
}
