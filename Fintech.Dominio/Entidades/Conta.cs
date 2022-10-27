using System.Collections.Generic;

namespace Fintech.Dominio.Entidades
{
    public abstract class Conta
    {
        public Conta(Agencia agencia, int numero, string digitoVerificador)
        {
            Agencia = agencia;
            Numero = numero;
            DigitoVerificador = digitoVerificador;
        }
        public int Id { get; set; }
        public int Numero { get; set; }
        public string DigitoVerificador { get; set; }
        public decimal Saldo { get; set; }
        public Agencia Agencia { get; set; }
        public Cliente Cliente { get; set; }
        public List<Movimento> Movimentos { get; set; } = new List<Movimento>();

        public virtual Movimento EfetuarOperacao(decimal valor, TipoOperacao tipoOperacao, decimal limite = 0)
        {
            var sucesso = true;
            Movimento movimento = null;

            switch (tipoOperacao)
            {
                case TipoOperacao.Deposito:
                    Saldo += valor;
                    //Saldo = Saldo + valor;
                    break;
                case TipoOperacao.Saque:
                    if (Saldo + limite >= valor)
                    {
                        Saldo -= valor; 
                    }
                    else
                    {
                        sucesso = false;
                    }
                    break;
            }

            if (sucesso)
            {
                movimento = new Movimento(valor, tipoOperacao,this);
               // movimento.Conta = this;

                Movimentos.Add(movimento);
            }
            return movimento;   
        }
    }
}