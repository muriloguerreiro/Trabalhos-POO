using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Murilo Guerreiro Badoco   11711ECP010 */

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Tempo t1 = new Tempo();
            Tempo t2 = new Tempo();
            t1.Solicita_Tempo();
            t1.Formata_Tempo();
            t2.Solicita_Tempo();
            t2.Formata_Tempo();
            Tempo t = new Tempo();
            t = t1.Adiciona_Tempo(t2);
            Console.Write("A soma dos dois tempos com ");
            t.Formata_Tempo();
            t = t1.Subtrai_Tempo(t2);
            Console.Write("A subtração dos dois tempos com ");
            t.Formata_Tempo();
            Console.ReadLine();
        }
    }
}
