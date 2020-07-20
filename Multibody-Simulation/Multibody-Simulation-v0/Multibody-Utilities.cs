/*
 * Landon Buell
 * Multibody Simulation
 * Utilities
 * 16 July 2020
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multibody_Simulation_v0
{
    static class Constants
    {
        public const double G_siUnits = 6.673e-11;
        public const double G_naturalUnits = 1e0;
        public const double G_astroUnits = 4.3009e-3;
    }

    class Multibody_System
    {
        // System Class Holds a list of all
        // Body objects in the current system
        public string name;
        public List <Body> bodies;
        public string dashes;

        public Multibody_System(string name, List<Body> bodies = null )
        {
            // Constructor for MultiBody System Class Object
            this.name = name;
            this.bodies = bodies;
            this.dashes = string.Concat(Enumerable.Repeat("-", 32));
        }

        public void Add_Body (Body body_inst)
        {
            // Add an Instance of a body object to This System
            this.bodies.Add(body_inst);
        }

        public List<Body> __getBodies__()
        {
            // return a list of all bodies in Current System
            return this.bodies;
        }

        public void System_Summary()
        {
            // Print Tabular Summary of System
            Console.WriteLine("System name", this.name);
            Console.WriteLine(this.dashes);

        }
        
    }
    

    class Body
    {
        // Create Name & Mass of body
        public string name;
        public double mass;
        public int radius;
        // Create position, velocity, accl vectors
        public List<double> pos;
        public List<double> vel;
        public List<double> acl;

        public Body(string name, float mass, int radius,
                        List<double> r, List<double> dr)
        {
            // Instatiate Body Class Object
            this.name = name;
            this.mass = mass;
            this.radius = radius;
            // Set Position, Velocity, and Acceleration Vectors
            this.pos = r;
            this.vel = dr;




        }   

 
    }
}
