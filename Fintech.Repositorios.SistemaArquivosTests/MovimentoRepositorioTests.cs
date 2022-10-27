using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fintech.Repositorios.SistemaArquivos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fintech.Dominio.Entidades;

namespace Fintech.Repositorios.SistemaArquivos.Tests
{
    [TestClass()]
    public class MovimentoRepositorioTests
    {
        [TestMethod()]
        public void InserirTest()
        {
            var movimentoRepositorio = new MovimentoRepositorio("Dados\\Movimento.txt");
            var agencia = new Agencia {Numero = 123};
            var conta = new ContaCorrente(agencia, 456, "X");


            var movimento = new Movimento(54, TipoOperacao.Deposito,conta);
            movimento.Conta = conta;
            
            movimentoRepositorio.Inserir(movimento);
        }
    }
}