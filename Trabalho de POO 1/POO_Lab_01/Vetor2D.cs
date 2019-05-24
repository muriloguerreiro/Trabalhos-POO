using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Lab_01
{
    class Vetor2D
    {
        private double x;
        private double y;

        /*     a)     */

        public Vetor2D()
        {
            x = 0;
            y = 0;
        }
        public Vetor2D(double X,double Y)
        {
            x = X;
            y = Y;
        }

        /*     b)     */

        public double Getx()
        {
            return this.x;
        }
        public void Setx(double X)
        {
            x = X;
        }
        public double Gety()
        {
            return this.y;
        }
        public void Sety(double Y)
        {
            y = Y;
        }

        /*     c)     */

        public double Produto_Escalar(Vetor2D vetor)
        {
            return (x * vetor.Getx() + y * vetor.Gety());
        }

        /*     d)     */

        public double Modulo_do_Vetor()
        {
            return Math.Sqrt(Math.Pow(x, 2.0) + Math.Pow(y, 2.0));
        }

        /*     e)     */

        public double Angulo_Dois_Vetores(Vetor2D vetor)
        {
            double cos;
            cos = (Produto_Escalar(vetor) / (Modulo_do_Vetor() * vetor.Modulo_do_Vetor()));
            return (Math.Acos(cos) * 180 / Math.PI);
        }

        /*     f)     */

        public Vetor2D Vetor_Projecao(Vetor2D vetor)
        {
            double proj;
            Vetor2D vetorprojecao = new Vetor2D();
            proj = (Produto_Escalar(vetor) / Produto_Escalar(this));
            vetorprojecao.Setx(Getx() * proj);
            vetorprojecao.Sety(Gety() * proj);
            return vetorprojecao;
        }
    }
}
