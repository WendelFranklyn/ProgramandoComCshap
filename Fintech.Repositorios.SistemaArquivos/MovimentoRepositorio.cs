using Fintech.Dominio.Entidades;
using System;
using System.IO;


namespace Fintech.Repositorios.SistemaArquivos
{
    public class MovimentoRepositorio
    {
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
    }
}