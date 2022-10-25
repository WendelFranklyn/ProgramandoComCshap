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

        public override void EfetuarOperacao(decimal valor, TipoOperacao tipoOperacao)
        {
            switch (tipoOperacao)
            {
                case TipoOperacao.Deposito:
                    Saldo += valor;
                    //Saldo = Saldo + valor;
                    break;
                case TipoOperacao.Saque:
                    if (Saldo >= valor)
                    {
                        Saldo -= valor;
                    }
                    break;
            }
        }
    }
}
