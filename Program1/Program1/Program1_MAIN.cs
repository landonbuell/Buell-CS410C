/*
 * Landon Buell
 * CS 410C
 * Program 1
 * 17 June 2020
 */


using System;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Linq;

namespace Program1
{

    class Point_Pair
    {
        // Initialize attribute of 2 points
        public double [] P;
        public double [] Q;

        public Point_Pair (double [] pt1 , double[] pt2)
        {
            // Initialize Object Instance by assigning points
            P = pt1;
            Q = pt2;
        }

        public double Distance ()
        {
            // Compute Euclidian Norm Between two points P & Q
            double dx2 = Math.Pow(P[0] - Q[0], 2);
            double dy2 = Math.Pow(P[1] - Q[1], 2);
            double dl = Math.Sqrt(dx2 + dy2);
            return dl; 
        }

        public double Bearing_Angle()
        {
            // Compute bearing angle from P to Q
            double dx = P[0] - Q[0];
            double dy = P[1] - Q[1];
            double bearing = Math.Atan2(dx, dy);
            return bearing;
        }

        public double Sweep_Angle()
        {
            // Compute sweep angle from O to P to Q
            double sweep_P = Math.Atan2(P[1], P[0]);
            double sweep_Q = Math.Atan2(Q[1], Q[0]);
            double sweep = sweep_Q - sweep_P;
            return sweep;
        }

    }

    class Conversions
    {
        public double rad_to_deg (double rad)
        {
            // convert argument 'rad' to units of degrees
            double deg = rad * (180 / Math.PI);
            return deg;
        }

        public double mtr_to_ft (double mtr)
        {
            // Convert argument 'mtr' into units of feet
            double ft = mtr * 3.281;
            return ft;
        }
    }


    class OutputTable
    {
        // Assign Points to Instance
        public double[] P;
        public double[] Q;

        public OutputTable(double[] pt1, double[] pt2)
        {
            // Initialize Object Instance by assigning points
            P = pt1;
            Q = pt2;
        }

        public void Header()
        {
            // Print Header for Tabel
            Console.Write("Points Are: ");
            Console.Write("( x1 , y1 ) = ");
            Console.Write("( {0} , {1} )", P[0], P[1]);
            Console.Write("\tand\t");
            Console.Write("( x2 , y2 ) = ");
            Console.Write("( {0} , {1} )", Q[0], Q[1]);
            Console.WriteLine('\n');
        }

        public void Hline()
        {
            // Print horizontal lines
            string dashes = string.Concat(Enumerable.Repeat("-",32));
            for (int i = 0; i < 2; i++)
            {
                Console.Write("+");
                Console.Write(dashes);
            }
            Console.Write("+", dashes);

        }
    }

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
            Table.Header();
            Table.Hline();
            
            
              
        }
    }
}
