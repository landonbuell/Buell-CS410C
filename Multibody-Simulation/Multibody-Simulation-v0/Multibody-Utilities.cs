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

namespace Multibody_Simulation_v0
{
    static class Constants
    {
        public static float G;

    }

    class System
    {
        // System Class Holds a list of all
        // Body objects in the current system
    }
    

    class Body
    {
        // Create Name & Mass of body
        public string name;
        public float mass;
        public int radius;
        // Create position, velocity, accl vectors
        public float x, y, z;
        public float dx, dy, dz;
        public float d2x, d2y, d2z;

        public Body(string name, float mass, int radius,
                        float[] pos, float[] vel)
        {
            // Instatiate Body Class Object
            this.name = name;
            this.mass = mass;
            this.radius = radius;
            // Set Position Vector Elements
            this.x = pos[0];
            this.y = pos[1];
            this.z = pos[2];
            // Set Velocity Vector Elements
            this.dx = vel[0];
            this.dy = vel[1];
            this.dz = vel[2];
            // Set Acceleration Vector Elements
            this.d2x = 0;
            this.d2y = 0;
            this.d2z = 0;
        }

        public float[] computeAcceleration(Body other)
        {
            // Compute accleration
            


            
        }

    }
}
