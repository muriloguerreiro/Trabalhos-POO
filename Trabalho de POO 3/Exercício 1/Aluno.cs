using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_LAB_03
{
    class Aluno
    {
        private string nome;
        private string matricula;
        private string periodo;
        Materia[] listaMateria = new Materia[20];

        int i, cont = 0;

        public Aluno()
        {
            nome = " ";
            matricula = " ";
            periodo = " ";
        }

        public Aluno(string _nome, string _matricula, string _periodo)
        {
            nome = _nome;
            this.matricula = _matricula;
            periodo = _periodo;
        }

        public String getNome()
        {
            return nome;
        }
        public void setNome(string _nome)
        {
            nome = _nome;
        }

        public string getMatricula()
        {
            return matricula;
        }
        public void setMatricula(string _matricula)
        {
            matricula = _matricula;
        }

        public string getPeriodo()
        {
            return periodo;
        }
        public void setPeriodo(string _periodo)
        {
            periodo = _periodo;
        }

        public void setMaterias(Materia materia)
        {

            listaMateria[i] = new Materia();
            listaMateria[i].setNome(materia.getNome());
            listaMateria[i].setCodigo(materia.getCodigo());
            i++;
            cont++;
        }

        public string getMaterias(int a)
        {
            if (a < cont)
            {
                return listaMateria[a].getNome();
            }
            else
            {
                return "fim";
            }
        }
    }
}
