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
    }
}
