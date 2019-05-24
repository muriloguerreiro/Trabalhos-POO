using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_LAB_03
{
    class Materia
    {
        private string nome;
        private string codigo;

        public Materia()
        {
            nome = " ";
            codigo = " ";
        }

        public Materia(string _nome, string _codigo)
        {
            nome = _nome;
            codigo = _codigo;
        }

        public string getNome()
        {
            return nome;
        }
        public void setNome(string _nome)
        {
            nome = _nome;
        }

        public String getCodigo()
        {
            return codigo;
        }
        public void setCodigo(string _codigo)
        {
            codigo = _codigo;
        }
        
        
    }
}
