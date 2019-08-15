using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aula1");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string nome, sobrenome;
            nome = "Kenzo";
            sobrenome = " Ishii";
            //interpolação
            string nomeCompleto = $"{nome} {sobrenome}";

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            int numeroInteiro;
            string tipoTexto;
            decimal ecimal;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            new multiplicacao().Show();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            new formula().Show();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            new salario().Show();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            new litrosdeCombustivel().Show();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            new pagamentoFuncionario().Show();
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            new ImparPar().Show();
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            new NumeroDivisivel().Show();
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            new juros().Show();
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            new PesoIdeal().Show();
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            new Idade().Show();
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            new formFormulario().Show();
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            new ImpressaoNumeros().Show();
        }
    }
}
