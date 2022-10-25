using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fintech.Dominio.Entidades
{
    public class Poupanca : Conta
    {
        public Poupanca(Agencia agencia, int numero, string digitoVerificador) : base(agencia, numero, digitoVerificador)   
        {

        }

        public decimal TaxaRendimento { get; set; } = 0.5m;
        public decimal TaxaCdi { get; set; }
    }
}
