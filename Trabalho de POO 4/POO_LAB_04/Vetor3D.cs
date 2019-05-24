using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_LAB_04
{
    class Vetor3D : Vetor2D
    {
        private double z;

        public Vetor3D() : base()
        {
            z = 0.0;
        }
        public Vetor3D(double _x, double _y, double _z) : base(_x, _y)
        {
            z = _z;
        }
        public double getZ()
        {
            return z;
        }
        public void setZ(double _z)
        {
            z = _z;
        }
        public double moduloVetorial3D()
        {
            return Math.Sqrt(Math.Pow(x, 2.0) + Math.Pow(y, 2.0) + Math.Pow(z, 2.0));
        }
        public Vetor3D produtoVetorial(Vetor3D v)
        {
            Vetor3D vr = new Vetor3D();
            vr.setX(y * v.getZ() - z * v.getY());
            vr.setY(z * v.getX() - x * v.getZ());
            vr.setZ(x * v.getY() - y * v.getX());
            return vr;
        }
    }
}
