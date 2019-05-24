using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Murilo Guerreiro Badoco   11711ECP010 */

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*   item d)    */

            List<Estacionamento> Matriz_Carros = new List<Estacionamento>();

            Console.WriteLine("Insira os dados de 5 carros: ");
            for (int i = 0; i < 5; i++)
            {
                Estacionamento e = new Estacionamento();
                e.Solicita_Dados();
                Matriz_Carros.Add(e);
            }
            Console.WriteLine("Relatorio dos carros");
            for (int i = 0; i < 5; i++)
            {
                Matriz_Carros[i].Imprime_Dados();
                Matriz_Carros[i].Valor_Estacionamento();
            }
            Console.ReadLine();
        }
    }
}
