using System;
using System.Windows.Forms;

namespace CSharp.Capitulo01.Variaveis
{
    public partial class VariaveisForm : Form
    {
        int x = 32;
        int y = 16;
        int w = 45;
        int z = 32;

        public VariaveisForm()
        {
            InitializeComponent();
        }

        private void aritmeticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // comentário.
            /*
             Comentário em
            várias linhas.
             */

            int x = 42;
            x = -9;
            //x = "58";
            //valor = 20;

            int meuInteiro = 10;
            string nome = "Vítor";
            char letra = 'V';
            DateTime dataNascimento = new DateTime(2000, 1, 1);

            bool aprovado = true;

            var valor = 22.09m;

            object meuObjeto = 18;
            meuObjeto = "35";
            meuObjeto = false;
            meuObjeto = new DateTime(2000, 1, 1);

            //decimal 1bimestre = 8.5m;
            var nomeCanção = "Release";
            string @class = "5D";

            var a = 2;
            var b = 6;
            var c = 10;
            var d = 13;

            //int e = 45;
            int f;
            //var g;

            resultadoListBox.Items.Add("a = " + a);
            resultadoListBox.Items.Add(string.Concat("b = ", b));
            //resultadoListBox.Items.Add(string.Format("c = {0}, d = {1}", c, d));
            resultadoListBox.Items.Add(string.Format("c = {0}", c));
            resultadoListBox.Items.Add($"d = {d}");

            resultadoListBox.Items.Add($"c * d = {c * d}");
            resultadoListBox.Items.Add($"d / a = {d / a}");
            resultadoListBox.Items.Add($"d % a = {d % a}");
        }

        private void reduzidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var x = 5;
            resultadoListBox.Items.Add("x = " + x);

            //x = x - 3;
            x -= 3;

            resultadoListBox.Items.Add("x = " + x);
        }

        private void incrementaisDecrementaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int a;

            a = 5;
            resultadoListBox.Items.Add("Exemplo de pré-incremental");
            resultadoListBox.Items.Add("a = " + a);
            resultadoListBox.Items.Add($"2 + ++a = {2 + ++a}");
            resultadoListBox.Items.Add("a = " + a);

            a = 5;
            resultadoListBox.Items.Add("Exemplo de pós-incremental");
            resultadoListBox.Items.Add("a = " + a);
            resultadoListBox.Items.Add($"2 + a++ = {2 + a++}");
            resultadoListBox.Items.Add("a = " + a);
        }

        private void booleanasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibirValores();

            resultadoListBox.Items.Add($"w <= x = {w <= x}");
            resultadoListBox.Items.Add($"x == z = {x == z}");
            resultadoListBox.Items.Add($"x != z = {x != z}");
        }

        private void ExibirValores()
        {
            resultadoListBox.Items.Add("x = " + x);
            resultadoListBox.Items.Add("y = " + y);
            resultadoListBox.Items.Add("w = " + w);
            resultadoListBox.Items.Add("z = " + z);
            resultadoListBox.Items.Add(new string('-', 50));
        }

        private void logicasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resultadoListBox.Items.Clear();

            ExibirValores();

            resultadoListBox.Items.Add($"w <= x || y == 16 = {w <= x || y == 16}");
            resultadoListBox.Items.Add($"x == z && x != z = {x == z && x != z}");
            resultadoListBox.Items.Add($"!(y > w) = {!(y > w)}");
        }

        private void ternariasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resultadoListBox.Items.Clear();

            int ano;

            ano = 2014;
            resultadoListBox.Items.Add($"O ano {ano} é bissexto? {(ano % 4 == 0 ? "Sim" : "Não")}.");

            ano = 2016;
            resultadoListBox.Items.Add($"O ano {ano} é bissexto? {(DateTime.IsLeapYear(ano) ? "Sim" : "Não")}.");

            //var resposta = "";
            //if (DateTime.IsLeapYear(ano))
            //{
            //    resposta = "Sim";
            //}
            //else
            //{
            //    resposta = "Não";
            //}
        }
    }
}