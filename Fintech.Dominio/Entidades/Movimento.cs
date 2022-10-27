using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fintech.Dominio.Entidades
{
    public class Movimento
    {
        public Movimento(decimal valor, TipoOperacao operacao)
        {
            Valor = valor;
            Operacao = operacao;
        }

        public Movimento(decimal valor, TipoOperacao tipoOperacao,Conta conta)
        {
            Valor = valor;
            TipoOperacao = tipoOperacao;
            Conta = Conta;
        }

        public int Id { get; set; }
        public Guid Guid { get; set; } = Guid.NewGuid();
        public DateTime Data { get; set; } = DateTime.Now;
        public TipoOperacao TipoOperacao { get; set; }
        public decimal Valor { get; set; }
        public Conta Conta { get; set; } //= new Conta();
        public TipoOperacao Operacao { get; }
    }
}
