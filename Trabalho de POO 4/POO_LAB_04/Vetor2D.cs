using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_LAB_04
{
    class Vetor2D
    {
        protected double x;
        protected double y;

        public Vetor2D()
        {
            x = 0.0;
            y = 0.0;
        }
        public Vetor2D(double _x, double _y)
        {
            x = _x;
            y = _y;
        }
        public double getX()
        {
            return x;
        }
        public void setX(double _x)
        {
            x = _x;
        }
        public double getY()
        {
            return y;
        }
        public void setY(double _y)
        {
            y = _y;
        }
        public double moduloVetorial()
        {
            return Math.Sqrt(Math.Pow(x, 2.0) + Math.Pow(y, 2.0));
        }
      
    }
}
