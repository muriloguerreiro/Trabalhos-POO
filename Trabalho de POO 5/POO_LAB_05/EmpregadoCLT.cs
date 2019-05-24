using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_LAB_05
{
    class EmpregadoCLT : Empregado
    {
        private double salario_mensal;

        //construtores

        public EmpregadoCLT() : base()
        {
            salario_mensal = 0.0;
        }

        public EmpregadoCLT(String _primeiroNome, String _endereco, String _CPF, Double _salario_mensal) :
            base(_primeiroNome, _endereco, _CPF)
        {
            salario_mensal = _salario_mensal;
        }

        //getters e setters

        public Double getsalario_mensal()
        {
            return this.salario_mensal;
        }

        public void setsalario_mensal(double _salario_mensal)
        {
            salario_mensal = _salario_mensal;
        }

        //metodos

        public override double getSalLiquido()
        {
            if (salario_mensal <= 5000)
                return salario_mensal * 0.85;
            else
                return salario_mensal * 0.725;
        }
    }
}
