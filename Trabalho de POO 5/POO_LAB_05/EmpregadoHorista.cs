using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_LAB_05
{
    class EmpregadoHorista : Empregado
    {
        private double nro_horas;
        private double qtd_horas;

        public EmpregadoHorista() : base()
        {
            nro_horas = 0.0;
            qtd_horas = 0.0;
        }
        public EmpregadoHorista(String _primeiroNome, String _endereco, String _CPF, Double _nro_horas, Double _qtd_horas) :
            base(_primeiroNome, _endereco, _CPF)
        {
            nro_horas = _nro_horas;
            qtd_horas = _qtd_horas;
        }

        public Double getnro_horas()
        {
            return nro_horas;
        }

        public Double getqtd_horas()
        {
            return qtd_horas;
        }

        public void setnro_horas(Double _nro_horas)
        {
            nro_horas = _nro_horas;
        }
        public void setqtd_horas(Double _qtd_horas)
        {
            qtd_horas = _qtd_horas;
        }

        public override double getSalLiquido()
        {
            return (nro_horas * qtd_horas) * 0.85;
        }
    }
}
