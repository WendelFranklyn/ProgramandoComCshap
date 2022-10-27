using Fintech.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.IO;


namespace Fintech.Repositorios.SistemaArquivos
{
    public class MovimentoRepositorio
    {
        public MovimentoRepositorio(string caminho)
        {
            Caminho = caminho;
        }


        public string Caminho { get; private set; }

        public void Inserir(Movimento movimento)
        {
            var registro = $"{movimento.Guid}|{movimento.Conta.Agencia.Numero}|" +
                $"{movimento.Conta.Numero}|{movimento.Data}|{movimento.TipoOperacao}|{movimento.Valor}";
            if (!Directory.Exists("Dados"))
            {
                Directory.CreateDirectory("Dados");
            }
            File.AppendAllText("Dados\\Movimento.txt",registro + Environment.NewLine);
        }

        public List<Movimento>Selecionar(int numeroAgencia,int numeroConta)
        {
            var movimentos = new List<Movimento>();

            foreach (var linha in File.ReadAllLines(Caminho))
            {
                if (linha != string.Empty)
                {
                    
                }
                var propriedades = linha.Split('|');

                var guid = new Guid (propriedades[0]);
                var propriedadeNumeroAgencia = Convert.ToInt32(propriedades[1]);
                var propriedadeNumeroConta = Convert.ToInt32(propriedades[2]);
                var data = Convert.ToDateTime(propriedades[3]);
                var operacao = (TipoOperacao)Convert.ToInt32(propriedades[4]);
                var valor = Convert.ToDecimal(propriedades[5]);

                if (numeroAgencia == propriedadeNumeroAgencia && numeroConta == propriedadeNumeroConta)
                {
                    var movimento = new Movimento(valor, operacao);
                    movimento.Data = data;

                    movimentos.Add(movimento);
                }
            }

            return movimentos;
        }
    }
}