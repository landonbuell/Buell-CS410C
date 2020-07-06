using System;
using System.Linq;


namespace Program1
{
    class Point_Pair
    {
        // Initialize attribute of 2 points
        public double[] P;
        public double[] Q;

        public Point_Pair(double[] pt1, double[] pt2)
        {
            // Initialize Object Instance by assigning points
            P = pt1;
            Q = pt2;
        }

        public double Distance()
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
        public double rad_to_deg(double rad)
        {
            // convert argument 'rad' to units of degrees
            double deg = rad * (180 / Math.PI);
            return deg;
        }

        public double mtr_to_ft(double mtr)
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

        public void Title()
        {
            // Print Header for Tabel
            Console.Write("Points Are: ");
            Console.Write("( x1 , y1 ) = ");
            Console.Write("( {0} , {1} )", P[0], P[1]);
            Console.Write("\tand\t");
            Console.Write("( x2 , y2 ) = ");
            Console.Write("( {0} , {1} )", Q[0], Q[1]);
            Console.WriteLine(' ');
        }

        public void Hline()
        {
            // Print horizontal lines
            string dashes = string.Concat(Enumerable.Repeat("-", 32));
            for (int i = 0; i < 2; i++)
            {
                Console.Write("+");
                Console.Write(dashes);
            }
            Console.Write("+", dashes);
        }

        public void Headers()
        {

        }
    }

}
