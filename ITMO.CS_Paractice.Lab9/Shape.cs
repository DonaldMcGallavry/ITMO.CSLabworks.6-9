using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.CS_Paractice.Lab9
{
    abstract class Shape
    {
        private int x;
        private int y;
        private int z;
        public abstract double Perimetr ();
        public abstract double Area ();

        public Shape (int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public Shape(int x)
        {
            this.x = x;
        }
        
    }
}
