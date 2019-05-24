using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Murilo Guerreiro Badoco 11711ECP010 */

namespace POO_Lab_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Vetor2D VetorA = new Vetor2D(3.0, 7.0);
            Vetor2D VetorB = new Vetor2D(2.0, 4.0);
            Console.WriteLine("Produto Escalar: " + VetorA.Produto_Escalar(VetorB));
            Console.WriteLine("Modulo do VetorA: " + VetorA.Modulo_do_Vetor());
            Console.WriteLine("Modulo do VetorB: " + VetorB.Modulo_do_Vetor());
            Console.WriteLine("Angulo Entre os Dois Vetores: " + VetorA.Angulo_Dois_Vetores(VetorB) + " graus");
            Vetor2D VetorProj = new Vetor2D();
            VetorProj = VetorA.Vetor_Projecao(VetorB);

            Console.WriteLine("Projeção do Vetor A no Vetor B: (" + VetorProj.Getx() + " , " + VetorProj.Gety() + ")");
            VetorProj = VetorB.Vetor_Projecao(VetorA);
            Console.WriteLine("Projeção do Vetor B no Vetor A: (" + VetorProj.Getx() + " , " + VetorProj.Gety() + ")");
            Console.ReadLine();
        }
    }
}
