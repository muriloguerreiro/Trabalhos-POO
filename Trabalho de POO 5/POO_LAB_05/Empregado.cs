using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_LAB_05
{
    class Empregado
    {
        protected String primeiroNome;
        protected String endereco;
        protected String CPF;

        //construtores
        public Empregado()
        {
            primeiroNome = " ";
            endereco = " ";
            CPF = " ";
        }

        public Empregado(String _primeiroNome, String _endereco, String _CPF)
        {
            primeiroNome = _primeiroNome;
            endereco = _endereco;
            CPF = _CPF;
        }

        //getters e setters
        public String getprimeiroNome()
        {
            return this.primeiroNome;
        }
        public void setprimeiroNome(String _primeiroNome)
        {
            primeiroNome = _primeiroNome;
        }


        public String getEndereco()
        {
            return this.endereco;
        }
        public void setEndereco(String _Endereco)
        {
            endereco = _Endereco;
        }


        public String getCPF()
        {
            return this.CPF;
        }
        public void setCPF(String _CPF)
        {
            CPF = _CPF;
        }

        // metodos
        public virtual double getSalLiquido()
        {
            return 0.0;
        }


    }
}
