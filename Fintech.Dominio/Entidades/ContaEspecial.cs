using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fintech.Dominio.Entidades
{
    public class ContaEspecial : ContaCorrente
    {
        public ContaEspecial(Agencia agencia, int numero, string digitoVerificador, decimal limite): base (agencia,numero,digitoVerificador)
        {
            Limite = limite;
        }

        public decimal Limite { get; set; }

        public override Movimento EfetuarOperacao(decimal valor, TipoOperacao tipoOperacao, decimal limite = 0)
        {
            return base.EfetuarOperacao (valor, tipoOperacao, Limite);
        }
    }
}
