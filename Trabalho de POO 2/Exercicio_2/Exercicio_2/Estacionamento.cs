using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Murilo Guerreiro Badoco   11711ECP010 */

namespace Exercicio_2
{
    class Estacionamento
    {
        private String chapa, marca;
        private Tempo entrada = new Tempo();
        private Tempo saida = new Tempo();

        public Estacionamento()
        {
            chapa = " ";
            marca = " ";
        }

        /*   item a)    */

        public void Solicita_Dados()
        {
            Console.WriteLine("Digite a chapa do carro: ");
            chapa = Console.ReadLine();
            Console.WriteLine("Digite a marca do carro: ");
            marca = Console.ReadLine();
            Console.WriteLine("Informações de entrada: ");
            entrada.Solicita_Tempo();
            Console.WriteLine("Informações de saida: ");
            saida.Solicita_Tempo();
        }

        /*   item b)    */

        public void Imprime_Dados()
        {
            Console.WriteLine("A chapa do carro é: " + chapa);
            Console.WriteLine("A marca do carro é: " + marca);
            Console.WriteLine("Hora de entrada: ");
            entrada.Formata_Tempo();
            Console.WriteLine("Hora de saida: ");
            saida.Formata_Tempo();
        }

        /*   item c)    */
        public void Valor_Estacionamento()
        {
            Tempo estacionamento = new Tempo();
            estacionamento = saida.Subtrai_Tempo(entrada);
            if (estacionamento.getHora() < 1) Console.WriteLine("O valor do estacionamento é R$7,00");
            else Console.WriteLine("O valor do estacionamento é R$" + (estacionamento.getHora() * 7) + ",00");
        }
    }
}