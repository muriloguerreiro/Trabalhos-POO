using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Murilo Guerreiro Badoco   11711ECP010 */

namespace Exercicio_2
{
    class Tempo
    {
        private int hora;
        private int min;
        private int seg;

        /*   item a)    */

        public Tempo()
        {
            hora = 0;
            min = 0;
            seg = 0;
        }

        /*   item b)    */

        public void Solicita_Tempo()
        {
            Console.WriteLine("Digite a Hora: ");
            hora = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os Minutos: ");
            min = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os Segundos: ");
            seg = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
        }

        /*   item c)    */

        public int getHora()
        {
            return this.hora;
        }
        public void setHora(int _hora)
        {
            hora = _hora;
        }
        public int getMin()
        {
            return this.min;
        }
        public void setMin(int _min)
        {
            min = _min;
        }
        public int getSeg()
        {
            return this.seg;
        }
        public void setSeg(int _seg)
        {
            seg = _seg;
        }

        /*   item d)    */

        public void Formata_Tempo()
        {
            if (hora < 10)
            {
                Console.Write("o tempo formatado é: 0" + hora);
            }
            else
            {
                Console.Write("o tempo formatado é: " + hora);
            }
            if (min < 10)
            {
                Console.Write(":0" + min);
            }
            else
            {
                Console.Write(":" + min);
            }
            if (seg < 10)
            {
                Console.Write(":0" + seg + "\n\n");
            }
            else
            {
                Console.Write(":" + seg + "\n\n");
            }
        }

        /*   item e)    */

        public Tempo Adiciona_Tempo(Tempo tempo)
        {
            Tempo t = new Tempo();

            t.setHora(hora + tempo.getHora());
            t.setMin(min + tempo.getMin());
            t.setSeg(seg + tempo.getSeg());

            if (t.seg >= 60)
            {
                t.seg = (t.seg - 60);
                t.min++;
            }
            if (t.min >= 60)
            {
                t.min = (t.min - 60);
                t.hora++;
            }

            return t;
        }

        /*   item f)    */

        public Tempo Subtrai_Tempo(Tempo tempo)
        {
            Tempo t = new Tempo();

            t.setHora(hora - tempo.getHora());
            t.setMin(min - tempo.getMin());
            t.setSeg(seg - tempo.getSeg());

            if (t.seg < 0)
            {
                t.seg = (60 + t.seg);
                t.min--;
            }
            if (t.min < 0)
            {
                t.min = (60 + t.min);
                t.hora--;
            }

            return t;
        }
    }
}
