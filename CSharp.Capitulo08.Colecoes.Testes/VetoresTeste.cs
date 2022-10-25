using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CSharp.Capitulo08.Colecoes.Testes
{
    [TestClass]
    public class VetoresTeste
    {
        [TestMethod]
        public void InicializacaoTeste()
        {
            //var inteiro = 89;
            var inteiros = new int[5];
            inteiros[0] = 14;
            inteiros[1] = 1;
            inteiros[2] = 7;
            inteiros[3] = 0;
            inteiros[4] = -14;
            //inteiros[5] = 9;

            //decimal meuDecimal = 8;
            var decimais = new decimal[] {0.4m, 0.9m, 4, 7.8m, 4.8m};

            string[] nomes = {"Vítor", "Avelino"};

            var chars = new[] {'a', 'b', 'c'};

            foreach (var @decimal in decimais)
            {
                Console.WriteLine(@decimal);
            }

            Console.WriteLine($"O tamanho do vetor {nameof(decimais)} é {decimais.Length}.");
        }

        [TestMethod]
        public void RedimensionamentoTeste()
        {
            var decimais = new decimal[] {0.4m, 0.9m, 4m, 7.8m, 4.8m};

            //decimais[0] = 0.5m;

            Array.Resize(ref decimais, 6);

            decimais[5] = -4.5m;
        }

        [TestMethod]
        public void OrdenacaoTeste() // usa o quicksort, não duplica o vetor.
        {
            var decimais = new decimal[] { 0.4m, 0.9m, -4m, 7.8m, 4.8m };

            Array.Sort(decimais);

            Assert.AreEqual(decimais[0], -4m);
        }

        [TestMethod]
        public void TodaStringEhUmVetorTeste()
        {
            var nome = "Vítor";
            nome += " Avelino";

            // StringBuilder

            Assert.AreEqual(nome[0], 'V');

            foreach (var @char in nome)
            {
                Console.Write(@char);
            }
        }
    }
}
