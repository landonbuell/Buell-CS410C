/*
 * Landon Buell
 * CS 410C
 * Program 0
 * 10 June 2020
 */

using System;
using System.Runtime.CompilerServices;

namespace Program0
{
    public class Ellipse
    {
        // Declare pi as double, set major and minor axes as attribute
        public double a;
        public double b;
        public double area;

        public Ellipse(double major, double minor)
        {
            // Initializer for Ellipse Class
            this.a = major;
            this.b = minor;
            this.area = Math.PI * this.a * this.b;
        }

        public double Ramanujan1()
        {
            // Compute Ramanujan's 1st Approximation of Ellipse Circumfrence
            double val_1 = (3 * this.a + this.b) * (this.a + 3 * this.b);
            double val_2 = 3 * (this.a + this.b) - Math.Sqrt(val_1);
            double crfm = Math.PI * (val_2);
            Console.WriteLine("\tRamanujan's 1st Approx - {0}", crfm);
            return crfm;
        }

        public double Ramanujan2()
        {
            // Compute Ramanujan's 2nd Approximation of Ellipse Circumfrence
            double h = Math.Pow(((this.a - this.b) / (this.a + this.b)), 2);
            double brak = 1 + (3 * h) / Math.Sqrt(10 + (4 - 3 * h)) ;
            double crfm = Math.PI * (this.a + this.b) * brak;
            Console.WriteLine("\tRamanujan's 2nd Approx - {0}", crfm);
            return crfm;
        }

        public double Muir()
        {
            // Compute Muir Formula Approximations of Ellipse Circumfrence
            double s = 1.5;
            double val_1 = Math.Pow(this.a, s) / 2 + Math.Pow(this.b, s) / 2;
            double crfm = 2 * Math.PI * Math.Pow(val_1, (1 / s));
            Console.WriteLine("\tMuir's Formula - {0}", crfm);
            return crfm;
        }

        public double Hudson()
        {
            // Compute Hudson Forumula Approximation of Ellipse Circumfrence
            double h = Math.Pow((this.a - this.b),2) / Math.Pow((this.a + this.b),2);
            double brak = (3 * (1 + h / 4) + 1) / (1 - h / 4);
            double crfm = 0.25 * Math.PI * (this.a + this.b) * brak;
            Console.WriteLine("\tHudson's Formula - {0}", crfm);
            return crfm;
        }

        public double Holder_Mean()
        {
            // Compute Holder Mean Approximation of Ellipse Circumfrence
            double s = Math.Log(2) / Math.Log(Math.PI / 2);
            double val_1 = Math.Pow(this.a, s) + Math.Pow(this.b, s);
            double crfm = 4 * Math.Pow(val_1, (1 / s));
            Console.WriteLine("\tHolder mean Formula - {0}", crfm);
            return crfm;
        }

        public double Cantrell()
        {
            // Compute Cantrell formula Approximation of Ellipse Circumfrence
            double s = 0.825056;
            var n = (4 * (this.a + this.b)) - (2 * (4 - Math.PI));
            double nmtr = n * (this.a * this.b);
            var _ = Math.Pow(this.a, s)/2 + Math.Pow(this.b, s)/2;
            double dmtr = Math.Pow( _ , (1 / s));
            double crfm = nmtr / dmtr;
            Console.WriteLine("\tCantrell Formula - {0}", crfm);
            return crfm;
        }


        class Program0_MAIN
        {
            static void Main()
            {
                // Accept User input for major & minor axes
                Console.WriteLine("Enter Ellipse Major Axis: ");
                string major_axis = Console.ReadLine();
                double A = Convert.ToDouble(major_axis);
                Console.WriteLine("Enter Ellipse Minor Axis: ");
                string minor_axis = Console.ReadLine();
                double B = Convert.ToDouble(minor_axis);

                // Create Class Instance & Run Approximations
                var my_Ellipse = new Ellipse(A, B);
                _ = my_Ellipse.Ramanujan1();
                _ = my_Ellipse.Ramanujan2();
                _ = my_Ellipse.Muir();
                _ = my_Ellipse.Hudson();
                _ = my_Ellipse.Holder_Mean();
                _ = my_Ellipse.Cantrell();
            }
        }
    }
}

