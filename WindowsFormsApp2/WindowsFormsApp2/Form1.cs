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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnChamarForm3_Click(object sender, EventArgs e)
        {
            new Form3().Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            new frmPoupanca().Show();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            new Form4().Show();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            new frmDatas().Show();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            new frmEnum().Show();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            new frmArray().Show();
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            
        }

        private void Button10_Click_1(object sender, EventArgs e)
        {
            new FrmAlunos().Show();
        }
    }
}
